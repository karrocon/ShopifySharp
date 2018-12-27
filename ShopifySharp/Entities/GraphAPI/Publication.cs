using GraphQlClient.Relay;

namespace ShopifySharp.Graph
{
    public class Publication : INode
    {
        #region Connections

        public Connection<ResourcePublication> CollectionPublicationsV3 { get; set; }
        public Connection<Collection> Collections { get; set; }
        public Connection<ResourcePublication> ProductPublicationsV3 { get; set; }
        public Connection<Product> Products { get; set; }

        #endregion

        #region Fields

        public App App { get; set; }
        public bool HasCollection { get; set; }
        // This should validate as ID https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        public string Name { get; set; }
        public bool SupportsFuturePublishing { get; set; }

        #endregion
    }
}