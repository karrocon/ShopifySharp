using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    public class FulfillmentService
    {
        public string Handle { get; set; }
        // This should validate as ID https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        public bool InventoryManagement { get; set; }
        public Location Location { get; set; }
        public bool ProductBased { get; set; }
        public string ServiceName { get; set; }
        public IEnumerable<ShippingMethod> ShippingMethods { get; set; }
        public FulfillmentServiceType Type { get; set; }
    }
}