using GraphQlClient.Relay;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class QueryRoot
    {
        public Connection<InventoryItem> InventoryItems { get; set; }
        public Connection<Location> Locations { get; set; }
        public Connection<ProductVariant> ProductVariants { get; set; }
    }
}
