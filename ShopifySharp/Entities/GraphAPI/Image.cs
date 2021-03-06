﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Image
    {
        public string AltText { get; set; }
        // This should validate Id https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/id
        public string Id { get; set; }
        // This should validate Url https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string OriginalSrc { get; set; }
        // This should validate Url https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string TransformedSrc { get; set; }
    }
}