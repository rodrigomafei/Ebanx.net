using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Responses.Base
{
    public class ResponseBase
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Success { get { return !string.IsNullOrEmpty(Status) && Status.Equals("SUCCESS"); } }
    }
}
