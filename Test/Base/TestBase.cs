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
                Payment = new PaymentKey
                {
                    StagIntegrationKey = "your key",
                    StagPublicIntegrationKey = "your key",
                    ProdIntegrationKey = "your key (not required to tests)",
                    ProdPublicIntegrationKey = "your key (not required to run tests)"
                }
            });
        }
    }
}
