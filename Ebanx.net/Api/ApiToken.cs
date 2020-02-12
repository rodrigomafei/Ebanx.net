using Ebanx.net.Api.Shared;
using Ebanx.net.Parameters.Requests;
using Ebanx.net.Parameters.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Api
{
    public class ApiToken : APIResource
    {
        public ApiToken()
        {
            BaseURI = "token";
        }

        public async Task<TokenResponse> GeneratedToken(TokenRequest tokenRequest)
        {
            return await PostAsync<TokenResponse>(tokenRequest);
        }
    }
}
