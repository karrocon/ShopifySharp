using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ProductInput
    {
        [JsonProperty("bodyHtml")]
        public string BodyHtml { get; set; }
        [JsonProperty("collectionsToJoin")]
        public IEnumerable<string> CollectionsToJoin { get; set; }
        [JsonProperty("collectionsToLeave")]
        public IEnumerable<string> CollectionsToLeave { get; set; }
        [JsonProperty("descriptionHtml")]
        public string DescriptionHtml { get; set; }
        [JsonProperty("giftCardTemplateSuffix")]
        public string GiftCardTemplateSuffix { get; set; }
        [JsonProperty("handle")]
        public string Handle { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("images")]
        public IEnumerable<ImageInput> Images { get; set; }
        [JsonProperty("metafields")]
        public IEnumerable<MetafieldInput> Metafields { get; set; }
        [JsonProperty("options")]
        public IEnumerable<string> Options { get; set; }
        [JsonProperty("productPublications")]
        public IEnumerable<ProductPublicationInput> ProductPublications { get; set; }
        [JsonProperty("productType")]
        public string ProductType { get; set; }
        [JsonProperty("publications")]
        public IEnumerable<ProductPublicationInput> Publications { get; set; }
        // Should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }
        // Should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        [JsonProperty("publishOn")]
        public string PublishOn { get; set; }
        [JsonProperty("published")]
        public bool? Published { get; set; }
        // Should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }
        [JsonProperty("redirectNewHandle")]
        public bool? RedirectNewHandle { get; set; }
        [JsonProperty("seo")]
        public SeoInput Seo { get; set; }
        [JsonProperty("tags")]
        public IEnumerable<string> Tags { get; set; }
        [JsonProperty("templateSuffix")]
        public string TemplateSuffix { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("variants")]
        public IEnumerable<ProductVariantInput> Variants { get; set; }
        [JsonProperty("vendor")]
        public string Vendor { get; set; }
    }
}