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
        public EbanxQueryOperationApi()
        {
            BaseURI = "query";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<QueryResponse> Create(QueryRequest request)
        {
            return await PostAsync<QueryResponse>(request);
        }
    }
}
