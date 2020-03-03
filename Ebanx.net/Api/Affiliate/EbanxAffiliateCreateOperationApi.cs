using Ebanx.net.Api.Shared;
using Ebanx.net.Parameters.Requests.Affiliate;
using Ebanx.net.Parameters.Responses.Affiliate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Api.Affiliate
{
    public class EbanxAffiliateCreateOperationApi : APIResource
    {
        public EbanxAffiliateCreateOperationApi()
        {
            SetBaseUri("recipient", APIType.Affiliate);
        }

        public async Task<CreateResponse> Create(CreateRequest request)
        {
            var headers = new Dictionary<string, string>
            {
                { "Authorization", request.AffiliateKey }
            };

            return await PostAsync<CreateResponse>(request, headers);
        }
    }
}
