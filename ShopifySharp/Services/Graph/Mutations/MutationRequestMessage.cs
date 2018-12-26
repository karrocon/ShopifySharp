using GraphQlClient.Client;

namespace ShopifySharp.Graph
{
    public interface IMutation<TResponse>
    {
        GraphQlRequestMessage ToGraphQlRequestMessage();
    }
}