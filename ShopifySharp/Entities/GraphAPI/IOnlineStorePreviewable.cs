namespace ShopifySharp.Graph
{
    internal interface IOnlineStorePreviewable
    {
        // This should validate as URL https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        string OnlineStorePreviewUrl { get; set; }
    }
}