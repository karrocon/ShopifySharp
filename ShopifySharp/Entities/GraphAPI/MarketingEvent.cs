using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class MarketingEvent : ILegacyInteroperability, INode
    {
        public App App { get; set; }
        public MarketingChannel? Channel { get; set; }
        public string Description { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public string EndedAt { get; set; }
        // This should validate as ID https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        public ulong? LegacyResourceId { get; set; }
        // This should validate as URL https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string ManageUrl { get; set; }
        // This should validate as URL https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string PreviewUrl { get; set; }
        public string RemoteId { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public string ScheduledToEndAt { get; set; }
        public string SourceAndMedium { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public string StartedAt { get; set; }
        public MarketingTactic? Type { get; set; }
        public string UtmCampaign { get; set; }
        public string UtmMedium { get; set; }
        public string UtmSource { get; set; }
    }
}