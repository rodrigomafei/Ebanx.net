using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Responses
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryResponse
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
        /// A JSON object that represents the payment.
        /// </summary>
        [JsonProperty("payment")]
        public PaymentResponse Payment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? Success
        {
            get
            {
                if (Status == null)
                    return false;

                return Status.ToUpper().Equals("SUCCESS");
            }
        }
    }
}
