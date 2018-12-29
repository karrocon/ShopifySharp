using Newtonsoft.Json;

namespace ShopifySharp.Graph
{
    public class InventoryLevelInput
    {
        [JsonProperty("availableQuantity")]
        public int AvailableQuantity { get; set; }
        [JsonProperty("locationId")]
        public string LocationId { get; set; }
    }
}