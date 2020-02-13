using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net
{
    public static class Start
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

        public string StagIntegrationKey { get; set; } = "your key";

        public string StagPublicIntegrationKey { get; set; } = "your key";
    }

    public class AffiliateKey
    {
        public string ProdIntegrationKey { get; set; }

        public string StagIntegrationKey { get; set; }
    }
}
