using Ebanx.net.Api;
using Ebanx.net.Parameters.Requests.QueryOperation;
using Ebanx.net.Parameters.Responses;
using Ebanx.net.Parameters.Responses.QueryOperation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Test.Base;

namespace Test
{
    [TestClass]
    public class QueryTest : TestBase
    {
        [TestMethod]
        public async Task Create()
        {
            var response = new QueryResponse();

            using (var api = new EbanxQueryOperationApi())
            {
                var request = new QueryRequest
                {
                };

                response = await api.Create(request);
            }

            Assert.IsFalse(response.Success);
        }
    }
}
