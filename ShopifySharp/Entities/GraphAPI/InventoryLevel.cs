using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class InventoryLevel : INode
    {
        public int? Available { get; set; }
        public bool? CanDeactivate { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public string CreatedAt { get; set; }
        public string DeactivationAlert { get; set; }
        // This should validate as ID https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        public int? Incoming { get; set; }
        public InventoryItem Item { get; set; }
        public Location Location { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public string UpdatedAt { get; set; }
    }
}