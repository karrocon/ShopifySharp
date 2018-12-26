using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    public class UserError
    {
        public IEnumerable<string> Field { get; set; }
        public string Message { get; set; }
    }
}