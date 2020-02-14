using Ebanx.net.Parameters.Responses.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Parameters.Responses.SetCvvOperation
{
    /// <summary>
    /// https://developers.ebanxpagamentos.com/api-reference/ebanx-payment-api/payment-reference/setcvv-operation/
    /// </summary>
    public class SetCvvResponse : ResponseBase
    {
        /// <summary>
        /// The token specified in the request.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// The masked credit card number. This can be stored and shown to the customer.
        /// </summary>
        [JsonProperty("masked_card_number")]
        public string MaskedCardNumber { get; set; }
    }
}
