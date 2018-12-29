using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ShopResourceLimits
    {
        public int? MaxProductOptions { get; set; }
        public int? MaxProductVariants { get; set; }
        public bool? RedirectLimitReached { get; set; }
        public ResourceLimit SkuResourceLimits { get; set; }
    }
}