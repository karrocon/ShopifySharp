using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class InventoryAdjustItemInput
    {
        public int? AvailableDelta { get; set; }
        public string InventoryItemId { get; set; }
    }
}