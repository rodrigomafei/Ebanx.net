using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Responses.Base
{
    public class ResponseBase
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        public bool Success { get { return Status.Equals("SUCCESS"); } }
    }
}
