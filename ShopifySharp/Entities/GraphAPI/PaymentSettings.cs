using System.Collections.Generic;

namespace ShopifySharp.Graph
{
    public class PaymentSettings
    {
        public IEnumerable<DigitalWallet> SupportedDigitalWallets { get; set; }
    }
}