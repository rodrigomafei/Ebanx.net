using Ebanx.net.Api.Shared;
using Ebanx.net.Parameters.Requests;
using Ebanx.net.Parameters.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Api
{
    public class EbanxTokenOperationApi : APIResource
    {
        public EbanxTokenOperationApi()
        {
            BaseURI = "token";
        }

        public async Task<TokenResponse> GeneratedToken(TokenRequest request)
        {
            return await PostAsync<TokenResponse>(request);
        }
    }
}
