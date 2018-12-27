using System;

namespace ShopifySharp.Graph
{
    public class ProductPublicationInput
    {
        public string ChannelHandle { get; set; }
        public string ChannelId { get; set; }
        public string PublicationId { get; set; }
        public DateTime PublishDate { get; set; }
    }
}