using GraphQlClient.Relay;

namespace ShopifySharp.Graph
{
    public interface IHasMetafields
    {
        Metafield Metafield { get; set; }
        Connection<Metafield> Metafields { get; set; }
    }
}