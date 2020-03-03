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
        public EbanxCancelOperationApi(CancelRequest request)
        {
            var uri = string.Format("cancel?integration_key={0}&hash={1}", request.IntegrationKey, request.Hash);

            SetBaseUri(uri);
        }

        public async Task<CancelResponse> Create()
        {
            return await GetAsync<CancelResponse>(null);
        }
    }
}
