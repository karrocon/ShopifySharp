using GraphQlClient;

namespace ShopifySharp.Graph
{
    public class GraphResponseMessage : GraphQlResponseMessage<QueryRoot>
    {
        public GraphResponseExtensions Extensions { get; set; }
    }
}
