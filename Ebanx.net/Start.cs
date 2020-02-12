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

        public string StagIntegrationKey { get; set; } = "1e6acd7fecb1475befe4d417b448c5c3844d8645a92596ec16fd56e5764672cd2ccecf7547a1ecd1f3244d426df2d6aa826a";

        public string StagPublicIntegrationKey { get; set; } = "4coOUeo9wkmdgUm7GwovATk0-9PSQKPFpnT_QXGPUu4";
    }

    public class AffiliateKey
    {
        public string ProdIntegrationKey { get; set; }

        public string StagIntegrationKey { get; set; }
    }
}
