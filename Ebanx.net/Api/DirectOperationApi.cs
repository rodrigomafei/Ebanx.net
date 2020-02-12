﻿using Ebanx.net.Api.Shared;
using Ebanx.net.Models.PaymentApi;
using Ebanx.net.Parameters.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Api
{
    public class DirectOperationApi : APIResource
    {
        public DirectOperationApi()
        {
            BaseURI = "direct";
        }

        public async Task<DirectResponse> GeneratedDirect(DirectRequest request)
        {
            return await PostAsync<DirectResponse>(request);
        }
    }
}