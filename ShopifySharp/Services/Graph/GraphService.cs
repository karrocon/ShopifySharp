using GraphQlClient;
using GraphQlClient.Relay;
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

        private void ShopifyGraphService_OnGraphQlError(object sender, IGraphQlEventArgs e)
        {
            WaitUntilNextRequest((GraphResponseMessage)e.Response);
        }

        private void ShopifyGraphService_OnBeforeQueryPage(object sender, IGraphQlEventArgs e)
        {
            WaitUntilNextRequest((GraphResponseMessage)e.Response);
        }

        #endregion

        #region Public methods

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

        #region Private helpers

        private void WaitUntilNextRequest(GraphResponseMessage responseMessage)
        {
            var availableAfterNextRequest = responseMessage.Extensions.Cost.ThrottleStatus.CurrentlyAvailable - responseMessage.Extensions.Cost.RequestedQueryCost;
            if (availableAfterNextRequest < 0)
            {
                var minimumSecondsUntilNextRequest = Math.Ceiling(-availableAfterNextRequest / responseMessage.Extensions.Cost.ThrottleStatus.RestoreRate);
                Thread.Sleep(TimeSpan.FromSeconds(minimumSecondsUntilNextRequest));
            }
        }

        #endregion
    }
}
