using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    public class ProductCreateMutationResult
    {
        public Product Product { get; set; }
        public Shop Shop { get; set; }
        public IEnumerable<UserError> UserErrors { get; set; }
    }
}