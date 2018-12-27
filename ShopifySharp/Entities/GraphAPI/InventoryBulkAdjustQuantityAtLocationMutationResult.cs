using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    public class InventoryBulkAdjustQuantityAtLocationMutationResult
    {
        public InventoryBulkAdjustQuantityAtLocation InventoryBulkAdjustQuantityAtLocation;
    }

    public class InventoryBulkAdjustQuantityAtLocation
    {
        public IEnumerable<InventoryLevel> InventoryLevels { get; set; }
        public IEnumerable<UserError> UserErrors { get; set; }
    }
}