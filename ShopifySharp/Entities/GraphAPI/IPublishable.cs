using GraphQlClient.Relay;

namespace ShopifySharp.Graph
{
    public interface IPublishable
    {
        int? AvailablePublicationCount { get; set; }
        int? PublicationCount { get; set; }
        bool? PublishedOnCurrentPublication { get; set; }
        bool? PublishedOnPublication { get; set; }
        Connection<ResourcePublication> ResourcePublications { get; set; }
        Connection<Publication> UnpublishedPublications { get; set; }
    }
}