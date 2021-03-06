﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class MetafieldInput
    {
        public string Description { get; set; }
        public string Id { get; set; }
        public string Key { get; set; }
        public string Namespace { get; set; }
        public string Value { get; set; }
        public MetafieldValueType? ValueType { get; set; }
    }
}