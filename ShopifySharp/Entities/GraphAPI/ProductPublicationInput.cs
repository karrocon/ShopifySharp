using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ProductPublicationInput
    {
        public string ChannelHandle { get; set; }
        public string ChannelId { get; set; }
        public string PublicationId { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public string PublishDate { get; set; }
    }
}