using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Requests.Base
{
    public class BaseRequest
    {
        [JsonProperty("integration_key")]
        public string IntegrationKey { get; set; }

        [JsonProperty("public_integration_key")]
        public string PublicIntegrationKey { get; set; }
    }
}
