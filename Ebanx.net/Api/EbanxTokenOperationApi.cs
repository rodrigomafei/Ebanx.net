using Ebanx.net.Api.Shared;
using Ebanx.net.Parameters.Requests;
using Ebanx.net.Parameters.Requests.TokenOperation;
using Ebanx.net.Parameters.Responses;
using Ebanx.net.Parameters.Responses.TokenOperation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Api
{
    /// <summary>
    /// 
    /// </summary>
    public class EbanxTokenOperationApi : APIResource
    {
        /// <summary>
        /// 
        /// </summary>
        public EbanxTokenOperationApi()
        {
            BaseURI = "token";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<TokenResponse> Create(TokenRequest request)
        {
            return await PostAsync<TokenResponse>(request);
        }
    }
}
