using Ebanx.net.Parameters.Requests;
using Ebanx.net.Parameters.Requests.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ebanx.net.Parameters.Requests.TokenOperation
{
    /// <summary>
    /// https://developers.ebanxpagamentos.com/api-reference/ebanx-payment-api/payment-reference/reference-token-operation/
    /// </summary>
    public class TokenRequest : RequestBaseWithKey
    {
        /// <summary>
        /// The credit card scheme: amex, elo, hipercard, mastercard, visa.
        /// </summary>
        [JsonProperty("payment_type_code"), StringLength(32), Required]
        public string PaymentTypeCode { get; set; }

        /// <summary>
        /// This must be set if you want to inform the token instead of letting EBANX create one.
        /// </summary>
        [JsonProperty("token"), MinLength(12), MaxLength(128)]
        public string Token { get; set; }

        /// <summary>
        /// The two-letter country code for the customer country. The available codes are:
        /// br: Brazil.
        /// </summary>
        [JsonProperty("country"), StringLength(2)]
        public string Country { get; set; }

        /// <summary>
        /// The credit card number (14-19 digits, must pass the Luhn algorithm).
        /// </summary>
        [JsonProperty("creditcard")]
        public CreditCardRequest CreditCard { get; set; }
    }
}
