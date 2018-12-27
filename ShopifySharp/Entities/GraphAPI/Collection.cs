using GraphQlClient.Relay;
using System;

namespace ShopifySharp.Graph
{
    public class Collection : IHasMetafields, INode, IPublishable
    {
        #region Connections

        public Connection<Metafield> Metafields { get; set; }
        public Connection<Product> Products { get; set; }
        public Connection<ResourcePublication> ResourcePublications { get; set; }
        public Connection<Publication> UnpublishedPublications { get; set; }

        #endregion

        #region Fields

        public int AvailablePublicationCount { get; set; }
        public string Description { get; set; }
        // This should validate as HTML https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/html
        public string DescriptionHtml { get; set; }
        public ResourceFeedback Feedback { get; set; }
        public string Handle { get; set; }
        public bool HasProduct { get; set; }
        // This should validate as Id https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        public Image Image { get; set; }
        public Metafield Metafield { get; set; }
        public int ProductsCount { get; set; }
        public int PublicationCount { get; set; }
        public bool PublishedOnCurrentPublication { get; set; }
        public bool PublishedOnPublication { get; set; }
        public CollectionRuleSet RuleSet { get; set; }
        public Seo Seo { get; set; }
        public CollectionSortOrder SortOrder { get; set; }
        // This should validate as StorefrontId https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/storefrontid
        public string StorefrontId { get; set; }
        public string TemplateSuffix { get; set; }
        public string Title { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public DateTime UpdatedAt { get; set; }

        #endregion
    }
}