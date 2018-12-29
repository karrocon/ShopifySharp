using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class LimitedPendingOrderCount
    {
        public bool? AtMax { get; set; }
        public int? Count { get; set; }
    }
}