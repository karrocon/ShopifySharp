using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ShopPlan
    {
        public string DisplayName { get; set; }
        public bool? PartnerDevelopment { get; set; }
        public bool? ShopifyPlus { get; set; }
    }
}