using Ebanx.net.Api;
using Ebanx.net.Parameters.Requests;
using Ebanx.net.Parameters.Requests.CancelOperation;
using Ebanx.net.Parameters.Requests.DirectOperation;
using Ebanx.net.Parameters.Responses.CancelOperation;
using Ebanx.net.Parameters.Responses.DirectOperation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Test.Base;

namespace Test
{
    [TestClass]
    public class CancelTest : TestBase
    {
        [TestMethod]
        public async Task Create()
        {
            var responseDirect = new DirectResponse();

            using (var directApi = new EbanxDirectOperationApi())
            {
                var r = new DirectRequest
                {
                    Operation = "request",
                    Mode = "full",
                    Payment = new PaymentRequest
                    {
                        Name = "Customer Name",
                        Email = "customer@mail.com",
                        AmountTotal = 500,
                        Zipcode = "000000",
                        Address = "Rua X",
                        StreetNumber = "5",
                        City = "City",
                        State = "SP",
                        Country = "BR",
                        PhoneNumber = "999999999",
                        CreditCard = CreaditCardRequestExtention.GetACard(),
                        CurrencyCode = "BRL",
                        MerchantPaymentCode = Guid.NewGuid().ToString(),
                        Document = "29479146002",
                        Instalments = 12
                    }
                };

                responseDirect = await directApi.Create(r);

                var response = new CancelResponse();

                using (var api = new EbanxCancelOperationApi())
                {
                    var request = new CancelRequest
                    {
                        Hash = responseDirect.Payment.Hash
                    };

                    response = await api.Create(request);
                }

                Assert.IsFalse(response.Success);
                //Assert.IsTrue(!string.IsNullOrEmpty(token?.Token));
            }
        }
    }
}
