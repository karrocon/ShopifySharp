using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class InventoryBulkAdjustQuantityAtLocationMutationResult
    {
        public InventoryBulkAdjustQuantityAtLocation InventoryBulkAdjustQuantityAtLocation;
    }

    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class InventoryBulkAdjustQuantityAtLocation
    {
        public IEnumerable<InventoryLevel> InventoryLevels { get; set; }
        public IEnumerable<UserError> UserErrors { get; set; }
    }
}