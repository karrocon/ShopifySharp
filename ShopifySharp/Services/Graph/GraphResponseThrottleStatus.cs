namespace ShopifySharp.Graph
{
    public class GraphResponseThrottleStatus
    {
        public double CurrentlyAvailable { get; set; }
        public double MaximumAvailable { get; set; }
        public double RestoreRate { get; set; }
    }
}