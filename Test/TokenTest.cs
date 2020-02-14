using Ebanx.net;
using Ebanx.net.Api;
using Ebanx.net.Parameters.Requests;
using Ebanx.net.Parameters.Requests.TokenOperation;
using Ebanx.net.Parameters.Responses;
using Ebanx.net.Parameters.Responses.TokenOperation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Test.Base;

namespace Test
{
    [TestClass]
    public class TokenTest : TestBase
    {
        [TestMethod]
        public async Task Create()
        {
            var token = new TokenResponse();

            using (var tokenApi = new EbanxTokenOperationApi())
            {
                var request = new TokenRequest
                {
                    Country = "BR",
                    CreditCard = CreaditCardRequestExtention.GetACard(),
                    PaymentTypeCode = "mastercard",
                };

                token = await tokenApi.Create(request);
            }

            Assert.IsTrue(token.Success);
            Assert.IsTrue(!string.IsNullOrEmpty(token?.Token));
        }

        [TestMethod]
        public async Task CreateWithInvalidCardInsufficientFunds()
        {
            var token = new TokenResponse();

            using (var tokenApi = new EbanxTokenOperationApi())
            {
                token = await tokenApi.Create(new TokenRequest
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
        public async Task CreateWithInvalidCardInvalidData()
        {
            var token = new TokenResponse();

            using (var tokenApi = new EbanxTokenOperationApi())
            {
                token = await tokenApi.Create(new TokenRequest
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
