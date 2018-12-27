namespace ShopifySharp.Graph
{
    public class ShopResourceLimits
    {
        public int MaxProductOptions { get; set; }
        public int MaxProductVariants { get; set; }
        public bool RedirectLimitReached { get; set; }
        public ResourceLimit SkuResourceLimits { get; set; }
    }
}