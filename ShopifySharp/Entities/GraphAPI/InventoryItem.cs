using GraphQlClient.Relay;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class InventoryItem : ILegacyInteroperability, INode
    {
        #region Connections

        public Connection<InventoryLevel> InventoryLevels { get; set; }

        #endregion

        #region Fields

        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public string CreatedAt { get; set; }
        // This should validate as ID https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        // This should validate as Url https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string InventoryHistoryUrl { get; set; }
        public InventoryLevel InventoryLevel { get; set; }
        public ulong? LegacyResourceId { get; set; }
        public int? LocationsCount { get; set; }
        public bool? RequiresShipping { get; set; }
        public string Sku { get; set; }
        public bool? Tracked { get; set; }
        public Money UnitCost { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public string UpdatedAt { get; set; }
        public ProductVariant Variant { get; set; }

        #endregion
    }
}