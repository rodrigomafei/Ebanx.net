using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Requests.Base
{
    public class RequestBase
    {
        [JsonProperty("integration_key")]
        public string IntegrationKey { get { return Start.Keys.Payment.StagIntegrationKey; } }

        [JsonProperty("public_integration_key")]
        public string PublicIntegrationKey { get { return Start.Keys.Payment.StagPublicIntegrationKey; } }
    }
}
