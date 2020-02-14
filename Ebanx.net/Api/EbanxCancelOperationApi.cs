using Ebanx.net.Api.Shared;
using Ebanx.net.Parameters.Requests.CancelOperation;
using Ebanx.net.Parameters.Responses.CancelOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Api
{
    /// <summary>
    /// 
    /// </summary>
    public class EbanxCancelOperationApi : APIResource
    {
        public EbanxCancelOperationApi()
        {
            BaseURI = "cancel";
        }

        public async Task<CancelResponse> Create(CancelRequest request)
        {
            return await PostAsync<CancelResponse>(request);
        }
    }
}
