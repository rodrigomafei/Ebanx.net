using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net
{
    public static class Parameters
    {
        public static EbanxKeys Keys { get; set; } = new EbanxKeys();
        
    }

    public class EbanxKeys
    {
        public EbanxKeys()
        {
            Payment = new PaymentKey();
            Affiliate = new AffiliateKey();
        }

        public PaymentKey Payment { get; set; }
        public AffiliateKey Affiliate { get; set; }
    }

    public class PaymentKey
    {
        public string ProdIntegrationKey { get; set; }
        public string StagIntegrationKey { get; set; }
    }

    public class AffiliateKey
    {
        public string ProdIntegrationKey { get; set; }
        public string StagIntegrationKey { get; set; }
    }
}
