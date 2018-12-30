using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class WebhookSubscriptionInput
    {
        // This should validate as URL https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string CallbackUrl { get; set; }
        public WebhookSubscriptionFormat Format { get; set; }
        public IEnumerable<string> IncludeFields { get; set; }
        public IEnumerable<string> MetafieldNamespaces { get; set; }
    }
}