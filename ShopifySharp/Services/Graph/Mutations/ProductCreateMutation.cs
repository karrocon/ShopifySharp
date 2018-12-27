using GraphQlClient;

namespace ShopifySharp.Graph
{
    public class ProductCreateMutation : IMutation<ProductCreateMutationResult>
    {
        public ProductInput Input { get; set; }

        public GraphQlRequestMessage ToGraphQlRequestMessage()
        {
            return new GraphQlRequestMessage
            {
                OperationName = "productCreate",
                Query = @"mutation productCreate($input: ProductInput!) {
                            productCreate(input: $input) {
                                userErrors {
                                    field
                                    message
                                }
                                product {
                                    id
                                }
                                shop {
                                    id
                                }
                            }
                        }",
                Variables = new
                {
                    input = Input
                }
            };
        }
    }
}
