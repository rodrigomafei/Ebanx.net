using Ebanx.net.Parameters.Requests.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Requests
{
    public class TokenRequest : BaseRequest
    {
        public TokenRequest()
        {
            CreditCard = new CreditCardRequest();
        }

        [JsonProperty("payment_type_code")]
        public string PaymentTypeCode { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("creditcard")]
        public CreditCardRequest CreditCard { get; set; }
    }
}
