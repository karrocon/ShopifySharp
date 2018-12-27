namespace ShopifySharp.Graph
{
    public class CollectionRule
    {
        public CollectionRuleColumn Column { get; set; }
        public string Condition { get; set; }
        public CollectionRuleRelation Relation { get; set; }
    }
}