using Newtonsoft.Json;

namespace ShopifySharp.Graph
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ImageInput
    {
        [JsonProperty("altText")]
        public string AltText { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("src")]
        public string Src { get; set; }
    }
}