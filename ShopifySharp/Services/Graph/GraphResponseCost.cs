namespace ShopifySharp.Graph
{
    public class GraphResponseCost
    {
        public int? ActualQueryCost { get; set; }
        public int RequestedQueryCost { get; set; }
        public GraphResponseThrottleStatus ThrottleStatus { get; set; }
    }
}