﻿namespace ShopifySharp.Graph
{
    public class SearchResult
    {
        public string Description { get; set; }
        public Image Image { get; set; }
        public INode Reference { get; set; }
        public string Title { get; set; }
        // This should validate as URL https://help.shopify.com/en/api/graphql-admin-api/reference/scalar/url
        public string Url { get; set; }
    }
}