using Ebanx.net.Parameters.Responses.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Responses
{
    /// <summary>
    /// 
    /// </summary>
    public class DirectResponse : ResponseBase
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("payment")]
        public PaymentResponse Payment { get; set; }

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
    }
}
