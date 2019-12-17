using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Models.PaymentApi
{
    public class QueryResponse
    {
        /// <summary>
        /// The status of the the request (SUCCESS or ERROR).
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_code")]
        public string StatusCode { get; set; }

        [JsonProperty("status_message")]
        public string StatusMessage { get; set; }

        /// <summary>
        /// A JSON object that represents the payment.
        /// </summary>
        [JsonProperty("payment")]
        public Payment Payment { get; set; }

        public bool Sucess 
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
