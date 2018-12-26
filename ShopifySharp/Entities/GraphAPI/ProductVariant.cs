using System;

namespace ShopifySharp.Graph
{
    public class ProductVariant : Node
    {
        #region Connections

        //public Connection<Metafield> Metafields { get; set; }
        //public Connection<ProductVariantPricePair> PresentmentPrices { get; set; }

        #endregion

        #region Properties

        public bool AvailableForSale { get; set; }
        public string Barcode { get; set; }
        public Money CompareAtPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public string DefaultCursor { get; set; }
        public string DisplayName { get; set; }
        //public FulfillmentService FulFillmentService { get; set; }
        public string HarmonizedSystemCode { get; set; }
        //public Image Image { get; set; }
        public InventoryItem InventoryItem { get; set; }
        //public ProductVariantInventoryPolicy InventoryPolicy { get; set; }
        public int InventoryQuantity { get; set; }
        public ulong LegacyResourceId { get; set; }
        //public Metafield Metafield { get; set; }
        public int Position { get; set; }
        public Money Price { get; set; }
        //public Product Product { get; set; }
        public bool RequiresShipping { get; set; }
        //public IEnumerable<SelectedOption> SelectedOptions { get; set; }
        public string Sku { get; set; }
        //public StorefrontID StorefrontId { get; set; }
        public bool Taxable { get; set; }
        public string Title { get; set; }
        public DateTime UpdatedAt { get; set; }
        public float Weight { get; set; }
        //public WeightUnit WeightUnit { get; set; }

        #endregion
    }
}