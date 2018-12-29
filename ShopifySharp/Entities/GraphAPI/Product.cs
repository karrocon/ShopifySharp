using GraphQlClient.Relay;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Product : IHasMetafields, ILegacyInteroperability, INode, INavigable, IOnlineStorePreviewable, IPublishable
    {
        #region Connections

        public Connection<Collection> Collections { get; set; }
        public Connection<Image> Images { get; set; }
        public Connection<Metafield> Metafields { get; set; }
        public Connection<ResourcePublication> ResourcePublications { get; set; }
        public Connection<Publication> UnpublishedPublications { get; set; }
        public Connection<ProductVariant> Variants { get; set; }

        #endregion

        #region Fields

        public int? AvailablePublicationCount { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public string CreatedAt { get; set; }
        public string DefaultCursor { get; set; }
        public string Description { get; set; }
        // This should validate as Html https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/html
        public string DescriptionHtml { get; set; }
        public Image FeaturedImage { get; set; }
        public ResourceFeedback Feedback { get; set; }
        public string GiftCardTemplateSuffix { get; set; }
        public string Handle { get; set; }
        public bool? HasOnlyDefaultVariant { get; set; }
        public bool? HasOutOfStockVariants { get; set; }
        // This should validate as ID https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        public bool? InCollection { get; set; }
        public bool? IsGiftCard { get; set; }
        public ulong? LegacyResourceId { get; set; }
        public Metafield Metafield { get; set; }
        // This should validate as Url https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string OnlineStorePreviewUrl { get; set; }
        // This should validate as Url https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string OnlineStoreUrl { get; set; }
        public IEnumerable<ProductOption> Options { get; set; }
        public ProductPriceRange PriceRange { get; set; }
        public string ProductType { get; set; }
        public int? PublicationCount { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public string PublishedAt { get; set; }
        public bool? PublishedOnCurrentPublication { get; set; }
        public bool? PublishedOnPublication { get; set; }
        public Seo Seo { get; set; }
        // This should validate as StorefrontId https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/storefrontid
        public string StorefrontId { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public string TemplateSuffix { get; set; }
        public string Title { get; set; }
        public int? TotalInventory { get; set; }
        public int? TotalVariants { get; set; }
        public bool? TracksInventory { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public string UpdatedAt { get; set; }
        public string Vendor { get; set; }

        #endregion
    }
}