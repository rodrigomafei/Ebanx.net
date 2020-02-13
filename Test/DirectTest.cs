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
    public class DirectTest
    {
        [TestMethod]
        public async Task GeneratedDirect()
        {
            var response = new DirectResponse();

            using (var directApi = new EbanxDirectOperationApi())
            {
                var request = new DirectRequest
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
                        SubAccount = new SubAccountRequest
                        {
                            Name = "SubAccount Name",
                            ImageUrl = "Image Uri"
                        },
                        CurrencyCode = "BRL",
                        MerchantPaymentCode = Guid.NewGuid().ToString(),
                        Document = "29479146002",
                        Instalments = 12
                    }
                };

                response = await directApi.GeneratedDirect(request);
            }

            Assert.IsTrue(response.Success);
            Assert.IsTrue(response.Payment.TransactionStatus.Success);
        }

        [TestMethod]
        public async Task GeneratedDirectInsufficientFundsCard()
        {
            var response = new DirectResponse();

            using (var directApi = new EbanxDirectOperationApi())
            {
                var request = new DirectRequest
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
                        CreditCard = CreaditCardRequestExtention.GetACard(CreaditCardRequestExtention.CreditCardTestRequestOperation.InsufficientFunds),
                        SubAccount = new SubAccountRequest
                        {
                            Name = "SubAccount Name",
                            ImageUrl = "Image Uri"
                        },
                        CurrencyCode = "BRL",
                        MerchantPaymentCode = Guid.NewGuid().ToString(),
                        Document = "29479146002",
                        Instalments = 12
                    }
                };

                response = await directApi.GeneratedDirect(request);
            }

            Assert.IsTrue(response.Success);
            Assert.IsFalse(response.Payment.TransactionStatus.Success);
        }
    }
}
