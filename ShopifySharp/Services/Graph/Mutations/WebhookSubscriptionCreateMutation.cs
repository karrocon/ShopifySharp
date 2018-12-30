using GraphQlClient;

namespace ShopifySharp.Graph
{
    public class WebhookSubscriptionCreateMutation : IMutation<WebhookSubscriptionCreateMutationResult>
    {
        public WebhookSubscriptionTopic Topic { get; set; }
        public WebhookSubscriptionInput WebhookSubscription { get; set; }

        public GraphQlRequestMessage ToGraphQlRequestMessage()
        {
            return new GraphQlRequestMessage
            {
                OperationName = "webhookSubscriptionCreate",
                Query = @"mutation webhookSubscriptionCreate($topic: WebhookSubscriptionTopic!, $webhookSubscription: WebhookSubscriptionInput!) {
                            productCreate(topic: $topic, webhookSubscription: $webhookSubscription) {
                                userErrors {
                                    field
                                    message
                                }
                                webhookSubscription {
                                    id
                                }
                            }
                        }",
                Variables = new
                {
                    topic = Topic,
                    webhookSubscription = WebhookSubscription
                }
            };
        }
    }
}
