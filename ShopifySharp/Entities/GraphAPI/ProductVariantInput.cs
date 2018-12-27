using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    public class ProductVariantInput
    {
        public string Barcode { get; set; }
        public Money CompareAtPrice { get; set; }
        public string FulFillmentServiceId { get; set; }
        public string HarmonizedSystemCode { get; set; }
        public string Id { get; set; }
        public string ImageId { get; set; }
        public string ImageSrc { get; set; }
        public InventoryItemInput InventoryItem { get; set; }
        public ProductVariantInventoryManagement InventoryManagement { get; set; }
        public ProductVariantInventoryPolicy InventoryPolicy { get; set; }
        public IEnumerable<InventoryLevelInput> InventoryQuantities { get; set; }
        public int InventoryQuantity { get; set; }
        public int InventoryQuantityAdjustment { get; set; }
        public IEnumerable<MetafieldInput> Metafields { get; set; }
        public IEnumerable<string> Options { get; set; }
        public int Position { get; set; }
        public Money Price { get; set; }
        public int ProductId { get; set; }
        public bool RequiresShipping { get; set; }
        public string Sku { get; set; }
        public string TaxCode { get; set; }
        public bool Taxable { get; set; }
        public string Title { get; set; }
        public float Weight { get; set; }
        public WeightUnit WeightUnit { get; set; }
    }
}