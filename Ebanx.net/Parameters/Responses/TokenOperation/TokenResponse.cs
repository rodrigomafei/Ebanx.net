using Ebanx.net.Parameters.Responses.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Responses.TokenOperation
{
    /// <summary>
    /// 
    /// </summary>
    public class TokenResponse : ResponseBase
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("payment_type_code")]
        public string PaymentTypeCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("masked_card_number")]
        public string MaskedCardNumber { get; set; }
    }
}
