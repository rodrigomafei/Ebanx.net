using Ebanx.net.Api.Shared;
using Ebanx.net.Parameters.Requests.RequestOperation;
using Ebanx.net.Parameters.Responses.RequestOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Api
{
    public class EbanxRequestOperationApi : APIResource
    {
        /// <summary>
        /// 
        /// </summary>
        public EbanxRequestOperationApi()
        {
            BaseURI = "request";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<RequestResponse> Create(RequestRequest request)
        {
            return await PostAsync<RequestResponse>(request);
        }
    }
}
