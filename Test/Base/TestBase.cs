using Ebanx.net;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Base
{
    public class TestBase
    {
        public TestBase()
        {
            new Config(new EbanxKeys
            {
                PaymentKeys = new PaymentKey
                {
                    StagIntegrationKey = Environment.GetEnvironmentVariable("EbanxStagIntegrationKey", EnvironmentVariableTarget.User),
                    StagPublicIntegrationKey = Environment.GetEnvironmentVariable("EbanxStagPublicIntegrationKey", EnvironmentVariableTarget.User),
                    ProdIntegrationKey = "your key (not required to tests)",
                    ProdPublicIntegrationKey = "your key (not required to run tests)"
                },
                AffiliateKeys = new AffiliateKey
                {
                    StagIntegrationKey = Environment.GetEnvironmentVariable("EbanxAffiliateStagIntegrationKey", EnvironmentVariableTarget.User),
                    ProdIntegrationKey = "your key (not required to run tests)"
                }
            });
        }
    }
}
