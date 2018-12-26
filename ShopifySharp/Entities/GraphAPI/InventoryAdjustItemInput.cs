using Newtonsoft.Json;

namespace ShopifySharp.Graph
{
    public class InventoryAdjustItemInput
    {
        [JsonProperty("availableDelta")]
        public int AvailableDelta { get; set; }
        [JsonProperty("inventoryItemId")]
        public string InventoryItemId { get; set; }
    }
}