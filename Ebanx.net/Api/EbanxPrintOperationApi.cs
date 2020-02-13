using Ebanx.net.Api.Shared;
using Ebanx.net.Parameters.Requests.PrintOperation;
using Ebanx.net.Parameters.Responses.PrintOperation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Api
{
    public class EbanxPrintOperationApi : APIResource
    {
        public EbanxPrintOperationApi()
        {
            BaseURI = "print";
        }

        public async Task<PrintResponse> Get(PrintRequest request)
        {
            return await GetAsync<PrintResponse>(request);
        }
    }
}
