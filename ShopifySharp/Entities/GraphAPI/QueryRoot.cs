using GraphQlClient.Relay.Entities;

namespace ShopifySharp.Graph
{
    public class QueryRoot
    {
        public Connection<InventoryItem> InventoryItems { get; set; }
        public Connection<Location> Locations { get; set; }
        public Connection<ProductVariant> ProductVariants { get; set; }
    }
}
