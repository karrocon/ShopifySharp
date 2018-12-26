using System;

namespace ShopifySharp.Graph
{
    public class InventoryLevel : Node
    {
        public int Available { get; set; }
        public bool CanDeactivate { get; set; }
        public DateTime CreatedAt { get; set; }
        public string DeactivationAlert { get; set; }
        public int Incoming { get; set; }
        public InventoryItem Item { get; set; }
        public Location Location { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}