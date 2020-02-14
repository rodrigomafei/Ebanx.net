using Ebanx.net.Parameters.Requests.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Parameters.Requests.SetCvvOperation
{
    /// <summary>
    /// https://developers.ebanxpagamentos.com/api-reference/ebanx-payment-api/payment-reference/setcvv-operation/
    /// </summary>
    public class SetCvvRequest : RequestBaseWithKey
    {
        /// <summary>
        /// The token that you want to associate the CVV with.
        /// </summary>
        [JsonProperty("token"), Required, MinLength(32), MaxLength(128)]
        public string Token { get; set; }

        /// <summary>
        /// Credit card security code.
        /// </summary>
        [JsonProperty("card_cvv"), Required, MinLength(3), MaxLength(4)]
        public string CardCvv { get; set; }
    }
}
