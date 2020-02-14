using Ebanx.net.Api;
using Ebanx.net.Parameters.Requests.RefundOrCancelOperation;
using Ebanx.net.Parameters.Responses.RefundOrCancelOperation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Test.Base;

namespace Test
{
    [TestClass]
    public class RefundOrCancelTest : TestBase
    {
        [TestMethod]
        public async Task Create()
        {
            var response = new RefundOrCancelResponse();

            using (var api = new EbanxRefundOrCancelOperationApi())
            {
                var request = new RefundOrCancelRequest
                {
                    Hash = "Cancel",
                    Description = "Description"
                };

                response = await api.Create(request);
            }

            Assert.IsFalse(response.Success);
        }
    }
}
