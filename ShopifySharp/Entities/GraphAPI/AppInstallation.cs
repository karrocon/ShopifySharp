using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    public class AppInstallation : INode
    {
        public IEnumerable<AccessScope> AccessScopes { get; set; }
        public App App { get; set; }
        // This should validate Id https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        // This should validate Url https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string LaunchUrl { get; set; }
        public Publication Publication { get; set; }
        // This should validate Url https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string UninstallUrl { get; set; }
    }
}