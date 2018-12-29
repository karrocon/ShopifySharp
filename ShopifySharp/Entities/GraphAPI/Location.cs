using GraphQlClient.Relay;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Location : ILegacyInteroperability, INode
    {
        #region Connections

        public Connection<InventoryLevel> InventoryLevels { get; set; }

        #endregion

        #region Fields

        public LocationAddress Address { get; set; }
        public FulfillmentService FulfillmentService { get; set; }
        // This should validate as ID https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        public InventoryLevel InventoryLevel { get; set; }
        public bool? IsActive { get; set; }
        public ulong? LegacyResourceId { get; set; }
        public string Name { get; set; }
        public bool? ShipsInventory { get; set; }

        #endregion
    }
}