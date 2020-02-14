using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Responses.Base
{
    /// <summary>
    /// 
    /// </summary>
    public class ResponseBase
    {
        /// <summary>
        /// The status of the the request (SUCCESS or ERROR).
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status_message")]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Return true if success
        /// </summary>
        public bool Success { get { return !string.IsNullOrEmpty(Status) && Status.Equals("SUCCESS"); } }
    }
}
