using Ebanx.net.Api.Shared;
using Ebanx.net.Parameters.Requests.RefundOrCancelOperation;
using Ebanx.net.Parameters.Responses.RefundOrCancelOperation;
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
    public class EbanxRefundOrCancelOperationApi : APIResource
    {
        /// <summary>
        /// 
        /// </summary>
        public EbanxRefundOrCancelOperationApi()
        {
            BaseURI = "refundOrCancel";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<RefundOrCancelResponse> Create(RefundOrCancelRequest request)
        {
            return await PostAsync<RefundOrCancelResponse>(request);
        }
    }
}
