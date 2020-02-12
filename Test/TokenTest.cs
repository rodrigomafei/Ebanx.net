using Ebanx.net.Api;
using Ebanx.net.Parameters.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class TokenTest
    {
        [TestMethod]
        public async Task GeneratedToken()
        {
            using (var tokenApi = new ApiToken())
            {
                var a = await tokenApi.GeneratedToken(new TokenRequest
                {
                    Country = "BR",
                    CreditCard = new CreditCardRequest
                    {
                        CardNumber = "378282246310005",
                        CVV = "0000",
                        CardName = "Test",
                        DueDate = "12/2027",
                    },
                    IntegrationKey = "1e6acd7fecb1475befe4d417b448c5c3844d8645a92596ec16fd56e5764672cd2ccecf7547a1ecd1f3244d426df2d6aa826a",
                    PaymentTypeCode = "amex",
                    PublicIntegrationKey = "4coOUeo9wkmdgUm7GwovATk0-9PSQKPFpnT_QXGPUu4",
                });
            }
        }
    }
}
