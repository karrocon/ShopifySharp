using GraphQlClient.Relay;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    public class ProductVariant : IHasMetafields, ILegacyInteroperability, INavigable, INode
    {
        #region Connections

        public Connection<Metafield> Metafields { get; set; }
        public Connection<ProductVariantPricePair> PresentmentPrices { get; set; }

        #endregion

        #region Fields

        public bool AvailableForSale { get; set; }
        public string Barcode { get; set; }
        public Money CompareAtPrice { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public string CreatedAt { get; set; }
        public string DefaultCursor { get; set; }
        public string DisplayName { get; set; }
        public FulfillmentService FulFillmentService { get; set; }
        public string HarmonizedSystemCode { get; set; }
        // This should validate as ID https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        public Image Image { get; set; }
        public InventoryItem InventoryItem { get; set; }
        public ProductVariantInventoryManagement InventoryManagement { get; set; }
        public ProductVariantInventoryPolicy InventoryPolicy { get; set; }
        public int InventoryQuantity { get; set; }
        public ulong LegacyResourceId { get; set; }
        public Metafield Metafield { get; set; }
        public int Position { get; set; }
        public Money Price { get; set; }
        public Product Product { get; set; }
        public bool RequiresShipping { get; set; }
        public IEnumerable<SelectedOption> SelectedOptions { get; set; }
        public string Sku { get; set; }
        // This should validate as StorefrontId https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/storefrontid
        public string StorefrontId { get; set; }
        public bool Taxable { get; set; }
        public string Title { get; set; }
        // This should validate as DateTime https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/datetime
        public string UpdatedAt { get; set; }
        public float Weight { get; set; }
        public WeightUnit WeightUnit { get; set; }

        #endregion
    }
}