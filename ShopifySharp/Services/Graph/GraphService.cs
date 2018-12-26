using GraphQlClient;
using GraphQlClient.Client;
using GraphQlClient.Relay.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp.Graph
{
    public class GraphService : GraphQlRelayClient
    {
        #region Properties

        public string AccessToken
        {
            get => _httpClient.DefaultRequestHeaders.FirstOrDefault(x => x.Key == "X-ShopifyAccess-Token").Value.FirstOrDefault();
            set => _httpClient.DefaultRequestHeaders.Add("X-Shopify-Access-Token", value);
        }

        public string Shop
        {
            get => _httpClient.BaseAddress.Host;
            set => _httpClient.BaseAddress = new Uri($"https://{value.TrimEnd('/')}/admin/api/graphql.json");
        }

        #endregion

        #region Constructors

        public GraphService(string shop, string accessToken)
        {
            AccessToken = accessToken;
            Shop = shop;

            OnBeforeQueryPage += ShopifyGraphService_OnBeforeQueryPage;
            OnGraphQlError += ShopifyGraphService_OnGraphQlError;
        }

        #endregion

        #region Event handlers

        private void ShopifyGraphService_OnGraphQlError(object sender, GraphQlEventArgs e)
        {
            var shopifyResponse = (GraphResponseMessage)e.Response;

            var availableAfterNextRequest = shopifyResponse.Extensions.Cost.ThrottleStatus.CurrentlyAvailable - shopifyResponse.Extensions.Cost.RequestedQueryCost;
            if (availableAfterNextRequest < 0)
            {
                var minimumSecondsUntilNextRequest = Math.Ceiling(-availableAfterNextRequest / shopifyResponse.Extensions.Cost.ThrottleStatus.RestoreRate);
                Thread.Sleep(TimeSpan.FromSeconds(minimumSecondsUntilNextRequest));
            }
        }

        private void ShopifyGraphService_OnBeforeQueryPage(object sender, GraphQlEventArgs e)
        {
            var shopifyResponse = (GraphResponseMessage)e.Response;

            var availableAfterNextRequest = shopifyResponse.Extensions.Cost.ThrottleStatus.CurrentlyAvailable - shopifyResponse.Extensions.Cost.RequestedQueryCost;
            if (availableAfterNextRequest < 0)
            {
                var minimumSecondsUntilNextRequest = Math.Ceiling(-availableAfterNextRequest / shopifyResponse.Extensions.Cost.ThrottleStatus.RestoreRate);
                Thread.Sleep(TimeSpan.FromSeconds(minimumSecondsUntilNextRequest));
            }
        }

        #endregion

        #region Public methods

        public Task<TResult> MutateAsync<TResult>(IMutation<TResult> mutation, uint retries = 0)
        {
            var request = mutation.ToGraphQlRequestMessage();

            return SendAsync<TResult>(request, retries);
        }

        public async Task<IEnumerable<QueryRoot>> QueryAsync(string query, string variables, uint retries = 0)
        {
            var request = new GraphQlRequestMessage
            {
                Query = query,
                Variables = variables
            };

            return (await QueryAllPagesAsync<GraphResponseMessage, QueryRoot>(request, retries)).Select(x => x.Data);
        }

        public Task<IEnumerable<QueryRoot>> QueryAsync(Action<IGraphQueryableObject<QueryRoot>> queryBuilder, dynamic variables = null, uint retries = 0)
        {
            return QueryAsync(GraphQueryStringBuilder.Build(queryBuilder), variables == null ? null : JsonConvert.SerializeObject(variables), retries);
        }

        #endregion
    }
}
