using Ebanx.net.Api;
using Ebanx.net.Parameters.Requests;
using Ebanx.net.Parameters.Responses;
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
            var token = new TokenResponse();

            using (var tokenApi = new TokenOperationApi())
            {
                var request = new TokenRequest
                {
                    Country = "BR",
                    CreditCard = CreaditCardRequestExtention.GetACard(),
                    PaymentTypeCode = "mastercard",
                };

                token = await tokenApi.GeneratedToken(request);
            }

            Assert.IsTrue(token.Success);
            Assert.IsTrue(!string.IsNullOrEmpty(token?.Token));
        }

        [TestMethod]
        public async Task GeneratedTokenInvalidCardInsufficientFunds()
        {
            var token = new TokenResponse();

            using (var tokenApi = new TokenOperationApi())
            {
                token = await tokenApi.GeneratedToken(new TokenRequest
                {
                    Country = "BR",
                    CreditCard = CreaditCardRequestExtention.GetACard(CreaditCardRequestExtention.CreditCardTestRequestOperation.InsufficientFunds),
                    PaymentTypeCode = "mastercard",
                });
            }

            Assert.IsTrue(token.Success);
            Assert.IsTrue(!string.IsNullOrEmpty(token?.Token));
        }

        [TestMethod]
        public async Task GeneratedTokenInvalidCardInvalidData()
        {
            var token = new TokenResponse();

            using (var tokenApi = new TokenOperationApi())
            {
                token = await tokenApi.GeneratedToken(new TokenRequest
                {
                    Country = "BR",
                    CreditCard = CreaditCardRequestExtention.GetACard(CreaditCardRequestExtention.CreditCardTestRequestOperation.InvalidData),
                    PaymentTypeCode = "mastercard",
                });
            }

            Assert.IsTrue(token.Success);
            Assert.IsTrue(!string.IsNullOrEmpty(token?.Token));
        }
    }
}
