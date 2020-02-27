using Ebanx.net.Api.Shared;
using Ebanx.net.Parameters.Requests.QueryOperation;
using Ebanx.net.Parameters.Responses;
using Ebanx.net.Parameters.Responses.QueryOperation;
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
    public class EbanxQueryOperationApi : APIResource
    {
        /// <summary>
        /// 
        /// </summary>
        public EbanxQueryOperationApi(QueryRequest request)
        {
            var uri = string.Format("query?integration_key={0}", request.IntegrationKey);

            if (!string.IsNullOrEmpty(request.Hash))
                uri += string.Format("&hash={0}", request.Hash);

            if (!string.IsNullOrEmpty(request.MerchantPaymentCode))
                uri += string.Format("&merchant_payment_code={0}", request.MerchantPaymentCode);

            BaseURI = uri;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<QueryResponse> Create()
        {

            return await GetAsync<QueryResponse>(null);
        }
    }
}
