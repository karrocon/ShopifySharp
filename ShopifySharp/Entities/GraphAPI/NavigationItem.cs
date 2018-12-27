namespace ShopifySharp.Graph
{
    public class NavigationItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        // This should validate Url https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string Url { get; set; }
    }
}