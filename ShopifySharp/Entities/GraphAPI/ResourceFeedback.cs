using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    public class ResourceFeedback
    {
        public IEnumerable<AppFeedback> Details { get; set; }
        public string Summary { get; set; }
    }
}