using Ebanx.net.Parameters.Responses.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Responses.TokenOperation
{
    public class TokenResponse : ResponseBase
    {
        [JsonProperty("payment_type_code")]
        public string PaymentTypeCode { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("masked_card_number")]
        public string MaskedCardNumber { get; set; }
    }
}
