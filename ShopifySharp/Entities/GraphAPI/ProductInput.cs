using System;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    public class ProductInput
    {
        public string BodyHtml { get; set; }
        public IEnumerable<string> CollectionsToJoin { get; set; }
        public IEnumerable<string> CollectionsToSave { get; set; }
        public string DescriptionHtml { get; set; }
        public string GiftCardTemplateSuffix { get; set; }
        public string Handle { get; set; }
        public string Id { get; set; }
        public IEnumerable<ImageInput> Images { get; set; }
        public IEnumerable<MetafieldInput> Metafields { get; set; }
        public IEnumerable<string> Options { get; set; }
        public IEnumerable<ProductPublicationInput> ProductPublications { get; set; }
        public string ProductType { get; set; }
        public IEnumerable<ProductPublicationInput> Publications { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime PublishOn { get; set; }
        public bool Published { get; set; }
        public DateTime PublishedAt { get; set; }
        public bool RedirectNewHandle { get; set; }
        public SeoInput Seo { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public string TemplateSuffix { get; set; }
        public string Title { get; set; }
        public IEnumerable<ProductVariantInput> Variants { get; set; }
        public string Vendor { get; set; }
    }
}