namespace ShopifySharp.Graph
{
    public interface INode
    {
        // This should validate Id https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        string Id { get; set; }
    }
}