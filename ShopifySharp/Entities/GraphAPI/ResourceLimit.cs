using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ResourceLimit
    {
        public bool? Available { get; set; }
        public int? QuantityAvailable { get; set; }
        public int? QuantityLimit { get; set; }
        public int? QuantityUsed { get; set; }
    }
}