using System;

namespace ShopifySharp.Graph
{
    public class ResourcePublication
    {
        public bool IsPublished { get; set; }
        public Publication Publication { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public DateTime PublishDate { get; set; }
        public IPublishable Publishable { get; set; }
    }
}