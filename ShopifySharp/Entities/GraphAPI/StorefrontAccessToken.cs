using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class StorefrontAccessToken : INode
    {
        public IEnumerable<AccessScope> AccessScopes { get; set; }
        public string AccessToken { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public string CreatedAt { get; set; }
        // This should validate as ID https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        public string Title { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public string UpdatedAt { get; set; }
    }
}