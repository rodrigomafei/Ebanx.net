using Ebanx.net.Api;
using Ebanx.net.Parameters.Requests;
using Ebanx.net.Parameters.Requests.DirectOperation;
using Ebanx.net.Parameters.Requests.TokenOperation;
using Ebanx.net.Parameters.Responses;
using Ebanx.net.Parameters.Responses.DirectOperation;
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
    public class DirectTest : TestBase
    {
        [TestMethod]
        public async Task Create()
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
                        Address = "Address X",
                        StreetNumber = "5",
                        City = "City",
                        State = "SP",
                        Country = "BR",
                        PhoneNumber = "999999999",
                        CreditCard = CreaditCardRequestExtention.GetACard(),
                        CurrencyCode = "BRL",
                        MerchantPaymentCode = Guid.NewGuid().ToString(),
                        Document = "29479146002",
                        Instalments = 12,
                        CreateToken = true
                    }
                };

                response = await directApi.Create(request);
            }

            Assert.IsTrue(response.Success);
            Assert.IsTrue(response.Payment.TransactionStatus.Success);
        }

        [TestMethod]
        public async Task CreateWithCreditCardToken()
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
                        CreditCard = new CreditCardRequest
                        {
                            Token = token.Token
                        },
                        CurrencyCode = "BRL",
                        MerchantPaymentCode = Guid.NewGuid().ToString(),
                        Document = "29479146002",
                        Instalments = 1
                    }
                };

                response = await directApi.Create(request);
            }

            Assert.IsTrue(response.Success);
            Assert.IsTrue(response.Payment.TransactionStatus.Success);
        }

        [TestMethod]
        public async Task CreateWithInsufficientFundsCard()
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
                        
                        //PaymentTypeCode = "boleto",
                        SubAccount = new SubAccountRequest
                        {
                            Name = "SubAccount Name",
                            ImageUrl = "Image Uri"
                        },
                        CurrencyCode = "BRL",
                        MerchantPaymentCode = Guid.NewGuid().ToString(),
                        Document = "29479146002",
                        Instalments = 1
                    }
                };

                response = await directApi.Create(request);
            }

            Assert.IsTrue(response.Success);
            Assert.IsFalse(response.Payment.TransactionStatus.Success);
        }
    }
}
