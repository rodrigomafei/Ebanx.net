using Ebanx.net.Api;
using Ebanx.net.Parameters.Requests.CaptureOperation;
using Ebanx.net.Parameters.Responses.CaptureOperation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Test.Base;

namespace Test
{
    [TestClass]
    public class CaptureTest : TestBase
    {
        [TestMethod]
        public async Task Create()
        {
            var response = new CaptureResponse();

            using (var tokenApi = new EbanxCaptureOperationApi())
            {
                var request = new CaptureRequest
                {
                     
                };

                response = await tokenApi.Create(request);
            }

            Assert.IsFalse(response.Success);
        }
    }
}
