using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class NavigationItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        // This should validate Url https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string Url { get; set; }
    }
}