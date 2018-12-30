using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class WebhookSubscription : ILegacyInteroperability, INode
    {
        // This should validate as URL https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string CallbackUrl { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public string CreatedAt { get; set; }
        public WebhookSubscriptionFormat? Format { get; set; }
        // This should validate as ID https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        public IEnumerable<string> IncludeFields { get; set; }
        public ulong? LegacyResourceId { get; set; }
        public IEnumerable<string> MetafieldNamespaces { get; set; }
        public WebhookSubscriptionTopic? Topic { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public string UpdatedAt { get; set; }
    }
}