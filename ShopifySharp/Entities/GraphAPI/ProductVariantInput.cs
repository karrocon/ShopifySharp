using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ProductVariantInput
    {
        [JsonProperty("barcode")]
        public string Barcode { get; set; }
        [JsonProperty("compareAtPrice")]
        public Money CompareAtPrice { get; set; }
        [JsonProperty("fulfillmentServiceId")]
        public string FulFillmentServiceId { get; set; }
        [JsonProperty("harmonizedSystemCode")]
        public string HarmonizedSystemCode { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("imageId")]
        public string ImageId { get; set; }
        [JsonProperty("imageSrc")]
        public string ImageSrc { get; set; }
        [JsonProperty("inventoryItem")]
        public InventoryItemInput InventoryItem { get; set; }
        [JsonProperty("inventoryManagement")]
        public ProductVariantInventoryManagement InventoryManagement { get; set; }
        [JsonProperty("inventoryPolicy")]
        public ProductVariantInventoryPolicy InventoryPolicy { get; set; }
        [JsonProperty("inventoryQuantities")]
        public IEnumerable<InventoryLevelInput> InventoryQuantities { get; set; }
        [JsonProperty("inventoryQuantity")]
        public int? InventoryQuantity { get; set; }
        [JsonProperty("inventoryQuantityAdjustment")]
        public int? InventoryQuantityAdjustment { get; set; }
        [JsonProperty("metafields")]
        public IEnumerable<MetafieldInput> Metafields { get; set; }
        [JsonProperty("options")]
        public IEnumerable<string> Options { get; set; }
        [JsonProperty("position")]
        public int? Position { get; set; }
        // This should validate as Money https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/money
        [JsonProperty("price")]
        public decimal? Price { get; set; }
        [JsonProperty("productId")]
        public int? ProductId { get; set; }
        [JsonProperty("requiresShipping")]
        public bool? RequiresShipping { get; set; }
        [JsonProperty("sku")]
        public string Sku { get; set; }
        [JsonProperty("taxCode")]
        public string TaxCode { get; set; }
        [JsonProperty("taxable")]
        public bool? Taxable { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("weight")]
        public float? Weight { get; set; }
        [JsonProperty("weightUnit")]
        public WeightUnit WeightUnit { get; set; }
    }
}