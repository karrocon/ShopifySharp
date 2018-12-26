using GraphQlClient.Relay.Entities;

namespace ShopifySharp.Graph
{
    public class Location : Node
    {
        public Connection<InventoryLevel> InventoryLevels { get; set; }

        public LocationAddress Address { get; set; }
        //public FulfillmentService FulfillmentService { get; set; }
        public InventoryLevel InventoryLevel { get; set; }
        public bool IsActive { get; set; }
        public ulong LegacyResourceId { get; set; }
        public string Name { get; set; }
        public bool ShipsInventory { get; set; }
    }
}