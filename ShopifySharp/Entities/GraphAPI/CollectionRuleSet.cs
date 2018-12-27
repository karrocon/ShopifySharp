using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    public class CollectionRuleSet
    {
        public bool AppliedDisjunctively { get; set; }
        public IEnumerable<CollectionRule> Rules { get; set; }
    }
}