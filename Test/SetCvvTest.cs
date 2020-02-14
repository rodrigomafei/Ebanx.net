using Ebanx.net.Api;
using Ebanx.net.Parameters.Requests;
using Ebanx.net.Parameters.Requests.SetCvvOperation;
using Ebanx.net.Parameters.Requests.TokenOperation;
using Ebanx.net.Parameters.Responses.SetCvvOperation;
using Ebanx.net.Parameters.Responses.TokenOperation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class SetCvvTest
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

            var response = new SetCvvResponse();

            using (var api = new EbanxSetCvvOperationApi())
            {
                var request = new SetCvvRequest
                {
                    CardCvv = "000",
                    Token = token.Token
                };

                response = await api.Create(request);
            }

            Assert.IsFalse(response.Success);
        }
    }
}
