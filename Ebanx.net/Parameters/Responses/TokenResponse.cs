using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Responses
{
    public class TokenResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("payment_type_code")]
        public string PaymentTypeCode { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("masked_card_number")]
        public string MaskedCardNumber { get; set; }

        public bool Success { get { return Status.Equals("SUCCESS"); } }
    }
}
