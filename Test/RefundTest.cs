using Ebanx.net.Api;
using Ebanx.net.Parameters.Requests.RefundOperation;
using Ebanx.net.Parameters.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Test.Base;

namespace Test
{
    [TestClass]
    public class RefundTest : TestBase
    {
        [TestMethod]
        public async Task Create()
        {
            var response = new RefundResponse();

            using (var api = new EbanxRefundOperationApi())
            {
                var request = new RefundRequest
                {
                    Operation = "Cancel"
                };

                response = await api.Create(request);
            }

            Assert.IsFalse(response.Success);
        }
    }
}
