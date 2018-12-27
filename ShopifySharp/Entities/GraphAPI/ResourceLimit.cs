namespace ShopifySharp.Graph
{
    public class ResourceLimit
    {
        public bool Available { get; set; }
        public int QuantityAvailable { get; set; }
        public int QuantityLimit { get; set; }
        public int QuantityUsed { get; set; }
    }
}