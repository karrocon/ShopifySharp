using GraphQlClient.Relay;
using System;

namespace ShopifySharp.Graph
{
    public class InventoryItem : Node
    {
        public Connection<InventoryLevel> InventoryLevels { get; set; }

        public DateTime CreatedAt { get; set; }
        public Uri InventoryHistoryUrl { get; set; }
        public InventoryLevel InventoryLevel { get; set; }
        public ulong LegacyResourceId { get; set; }
        public int LocationsCount { get; set; }
        public bool RequiresShipping { get; set; }
        public string Sku { get; set; }
        public bool Tracked { get; set; }
        public Money UnitCost { get; set; }
        public DateTime UpdatedAt { get; set; }
        //public ProductVariant Variant { get; set; }
    }
}