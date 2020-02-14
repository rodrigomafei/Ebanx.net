using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Responses
{
    public class DetailsResponse
    {
        /// <summary>
        /// The billing descriptor of the payment.
        /// </summary>
        [JsonProperty("billing_descriptor")]
        public string BillingDescriptor { get; set; }
    }
}
