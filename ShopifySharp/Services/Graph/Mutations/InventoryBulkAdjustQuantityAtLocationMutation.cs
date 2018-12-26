using GraphQlClient;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    public class InventoryBulkAdjustQuantityAtLocationMutation : IMutation<InventoryBulkAdjustQuantityAtLocationMutationResult>
    {
        public IEnumerable<InventoryAdjustItemInput> InventoryItemAdjustments { get; set; }
        public string LocationId { get; set; }

        public GraphQlRequestMessage ToGraphQlRequestMessage()
        {
            return new GraphQlRequestMessage
            {
                OperationName = "inventoryBulkAdjustQuantityAtLocation",
                Query = @"mutation inventoryBulkAdjustQuantityAtLocation($inventoryItemAdjustments: [InventoryAdjustItemInput!]!, $locationId: ID!) {
                            inventoryBulkAdjustQuantityAtLocation(inventoryItemAdjustments: $inventoryItemAdjustments, locationId: $locationId) {
                                userErrors {
                                    field
                                    message
                                }
                                inventoryLevels {
                                    id
                                }
                            }
                        }",
                Variables = new
                {
                    inventoryItemAdjustments = InventoryItemAdjustments,
                    locationId = LocationId
                }
            };
        }
    }
}
