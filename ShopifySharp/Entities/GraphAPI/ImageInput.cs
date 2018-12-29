using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ImageInput
    {
        public string AltText { get; set; }
        public string Id { get; set; }
        public string Src { get; set; }
    }
}