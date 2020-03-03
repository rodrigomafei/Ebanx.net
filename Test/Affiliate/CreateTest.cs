using Ebanx.net.Api.Affiliate;
using Ebanx.net.Models.AffiliateApi;
using Ebanx.net.Parameters.Requests.Affiliate;
using Ebanx.net.Parameters.Responses.Affiliate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Test.Base;

namespace Test.Affiliate
{
    [TestClass]
    public class CreateTest : TestBase
    {
        [TestMethod]
        public async Task Create()
        {
            var request = new CreateRequest
            {
                Name = "Test",
                RecipientType = CreateRequest.RecipientTypes.individual,
                CountryCode = Ebanx.net.Models.Country.CountryCodes.BRA,
                Document = new EntityDocument
                {
                    CountryCode = Ebanx.net.Models.Country.CountryCodes.BRA,
                    Number = (10000000000 + new Random().Next(1,9999999)).ToString(),
                    DocumentType = EntityDocument.DocumentTypes.cpf
                },
                BankAccounts = new List<BankAccount>
                {
                    new BankAccount {
                    BankAccountType = BankAccount.BankAccountTypes.corrente,
                    Number = "123",
                    BankBranchCode = "BB",
                    BankIdentifier = "001",
                    BranchVerificationCode = "1",
                    VerificationCode = "1"
                    }
                },
                CustomerReference = "aaa"

            };

            var response = new CreateResponse();

            using (var api = new EbanxAffiliateCreateOperationApi())
            {
                response = await api.Create(request);
            }

            Assert.IsTrue(response.Status.ToUpper().Equals("OK"));
        }
    }
}
