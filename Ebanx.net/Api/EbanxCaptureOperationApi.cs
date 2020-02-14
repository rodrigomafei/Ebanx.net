using Ebanx.net.Api.Shared;
using Ebanx.net.Parameters.Requests.CaptureOperation;
using Ebanx.net.Parameters.Responses.CaptureOperation;
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
    public class EbanxCaptureOperationApi : APIResource
    {
        /// <summary>
        /// 
        /// </summary>
        public EbanxCaptureOperationApi()
        {
            BaseURI = "capture";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CaptureResponse> Create(CaptureRequest request)
        {
            return await PostAsync<CaptureResponse>(request);
        }
    }
}
