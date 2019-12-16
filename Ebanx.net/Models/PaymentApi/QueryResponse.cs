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

        /// <summary>
        /// A JSON object that represents the payment.
        /// </summary>
        [JsonProperty("payment")]
        public Payment Payment { get; set; }
    }
}
