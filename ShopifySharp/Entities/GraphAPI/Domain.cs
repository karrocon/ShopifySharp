using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Domain : INode
    {
        public string Host { get; set; }
        // This should validate as ID https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        public bool? SslEnabled { get; set; }
        // This should validate as URL https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string Url { get; set; }
    }
}