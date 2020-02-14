using Ebanx.net.Api;
using Ebanx.net.Parameters.Requests.RequestOperation;
using Ebanx.net.Parameters.Responses.RequestOperation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Test.Base;

namespace Test
{
    [TestClass]
    public class RequestTest : TestBase
    {
        [TestMethod]
        public async Task Create()
        {
            var response = new RequestResponse();

            using (var api = new EbanxRequestOperationApi())
            {
                var request = new RequestRequest
                {
                    Address = "Test Address",
                    Amount = 50,
                    City = "City",
                    Country = "BR",
                    Name = "Name",
                    Email = "mail@mail.com",
                    CurrencyCode = "BRL",
                    PaymentTypeCode = "mastercard",
                    Instalments = "1-6",
                    DueDate = "12/12/2020",
                    MerchantPaymentCode = "1",
                };

                response = await api.Create(request);
            }

            Assert.IsFalse(response.Success);
        }

    }
}
