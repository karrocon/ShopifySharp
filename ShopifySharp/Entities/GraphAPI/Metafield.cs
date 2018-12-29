﻿namespace ShopifySharp.Graph
{
    public class Metafield : ILegacyInteroperability, INode
    {
        public string Description { get; set; }
        public string Id { get; set; }
        public string Key { get; set; }
        public ulong LegacyResourceId { get; set; }
        public string Namespace { get; set; }
        public string Value { get; set; }
        public MetafieldValueType ValueType { get; set; }
    }
}