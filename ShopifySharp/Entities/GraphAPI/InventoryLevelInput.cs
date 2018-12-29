using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class InventoryLevelInput
    {
        public int? AvailableQuantity { get; set; }
        public string LocationId { get; set; }
    }
}