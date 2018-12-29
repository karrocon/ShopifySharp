using GraphQlClient.Relay;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Shop : IHasMetafields, INode
    {
        #region Connections

        public Connection<App> AvailableChannelApps { get; set; }
        public Connection<string> CustomerTags { get; set; }
        public Connection<string> DraftOrderTags { get; set; }
        public Connection<MarketingEvent> MarketingEvents { get; set; }
        public Connection<Metafield> Metafields { get; set; }
        public Connection<string> OrderTags { get; set; }
        public Connection<Image> ProductImages { get; set; }
        public Connection<string> ProductTags { get; set; }
        public Connection<string> ProductTypes { get; set; }
        public Connection<string> ProductVendors { get; set; }
        public Connection<SearchResult> Search { get; set; }
        public Connection<StorefrontAccessToken> StorefrontAccessTokens { get; set; }
        public Connection<Image> UploadedImages { get; set; }

        #endregion

        #region Fields

        public IEnumerable<ShopAlert> Alerts { get; set; }
        public string AnalyticsToken { get; set; }
        public MailingAddress BillingAddress { get; set; }
        public bool? CheckoutApiSupported { get; set; }
        public string ContactEmail { get; set; }
        public CountriesInShippingZones CountriesInShippingZones { get; set; }
        public CurrencyCode? CurrencyCode { get; set; }
        public ShopCustomerAccountsSetting? CustomerAccounts { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public IEnumerable<CurrencyCode> EnabledPresentmentCurrencies { get; set; }
        public ShopFeatures Features { get; set; }
        public IEnumerable<FulfillmentService> FulfillmentServices { get; set; }
        public string IanaTimezone { get; set; }
        // This should validate as ID https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        public LimitedPendingOrderCount LimitedPendingOrderCount { get; set; }
        public Metafield Metafield { get; set; }
        public string MyshopifyDomain { get; set; }
        public string Name { get; set; }
        public IEnumerable<NavigationItem> NavigationSettings { get; set; }
        public PaymentSettings PaymentSettings { get; set; }
        public ShopPlan Plan { get; set; }
        public Domain PrimaryDomain { get; set; }
        public int? PublicationCount { get; set; }
        public ShopResourceLimits ResourceLimits { get; set; }
        // This should validate as URL https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string RichTextEditorUrl { get; set; }
        public SearchFilterOptions SearchFilters { get; set; }
        public bool? SetupRequired { get; set; }
        public IEnumerable<CountryCode> ShipsToCountries { get; set; }
        public bool? TaxShipping { get; set; }
        public bool? TaxesIncluded { get; set; }
        public string TimezoneOffset { get; set; }
        public int? TimezoneOffsetMinutes { get; set; }
        // This should validate as URL https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string Url { get; set; }
        public WeightUnit? WeightUnit { get; set; }

        #endregion
    }
}