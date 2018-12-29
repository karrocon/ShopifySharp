using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class App : INode
    {
        public string ApiKey { get; set; }
        // This should validate Url https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string AppStoreAppUrl { get; set; }
        // This should validate Url https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string AppStoreDeveloperUrl { get; set; }
        public Image Banner { get; set; }
        public string Description { get; set; }
        public string DeveloperName { get; set; }
        public bool? Embedded { get; set; }
        public IEnumerable<FailedRequirement> FailedRequirements { get; set; }
        public IEnumerable<string> Features { get; set; }
        public AppFeedback Feedback { get; set; }
        public string Handle { get; set; }
        public Image Icon { get; set; }
        // This should validate Id https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        // This should validate Url https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string InstallUrl { get; set; }
        public AppInstallation Installation { get; set; }
        public string PricingDetails { get; set; }
        public string PricingDetailsSummary { get; set; }
        // This should validate Url https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string PrivacyPolicyUrl { get; set; }
        public bool? Published { get; set; }
        public IEnumerable<Image> Screenshots { get; set; }
        public bool? ShopifyDeveloped { get; set; }
        public string Title { get; set; }
        public string UninstallMessage { get; set; }
    }
}