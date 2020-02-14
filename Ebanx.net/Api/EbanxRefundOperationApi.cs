using Ebanx.net.Api.Shared;
using Ebanx.net.Parameters.Requests.RefundOperation;
using Ebanx.net.Parameters.Responses;
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
    public class EbanxRefundOperationApi : APIResource
    {
        /// <summary>
        /// 
        /// </summary>
        public EbanxRefundOperationApi()
        {
            BaseURI = "refund";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<RefundResponse> Create(RefundRequest request)
        {
            return await PostAsync<RefundResponse>(request);
        }
    }
}
