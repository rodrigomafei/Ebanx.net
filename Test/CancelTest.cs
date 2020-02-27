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
                        CurrencyCode = "BRL",
                        MerchantPaymentCode = Guid.NewGuid().ToString(),
                        Document = "29479146002",
                        Instalments = 1,
                        PaymentTypeCode = "boleto",
                        DueDate = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    }
                };

                responseDirect = await directApi.Create(r);

                var response = new CancelResponse();

                var request = new CancelRequest
                {
                    Hash = responseDirect.Payment.Hash
                };

                using (var api = new EbanxCancelOperationApi(request))
                {
                    response = await api.Create();
                }

                Assert.IsFalse(response.Success);
                //Assert.IsTrue(!string.IsNullOrEmpty(token?.Token));
            }
        }
    }
}
