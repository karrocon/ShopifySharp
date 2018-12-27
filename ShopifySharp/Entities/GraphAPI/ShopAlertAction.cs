namespace ShopifySharp.Graph
{
    public class ShopAlertAction
    {
        public string Title { get; set; }
        // This should validate as URL https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string Url { get; set; }
    }
}