using Ebanx.net.Api.Shared;
using Ebanx.net.Parameters.Requests.SetCvvOperation;
using Ebanx.net.Parameters.Responses.SetCvvOperation;
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
    public class EbanxSetCvvOperationApi : APIResource
    {
        /// <summary>
        /// 
        /// </summary>
        public EbanxSetCvvOperationApi()
        {
            BaseURI = "setCvv";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SetCvvResponse> Create(SetCvvRequest request)
        {
            return await PostAsync<SetCvvResponse>(request);
        }
    }
}
