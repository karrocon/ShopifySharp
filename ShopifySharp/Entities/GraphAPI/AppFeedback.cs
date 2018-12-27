using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    public class AppFeedback
    {
        public App App { get; set; }
        public Link Link { get; set; }
        public IEnumerable<UserError> Messages { get; set; }
    }
}