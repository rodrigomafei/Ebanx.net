using Ebanx.net.Parameters.Requests.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Parameters.Requests.QueryOperation
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryRequest : RequestBaseWithKey
    {
        /// <summary>
        /// The payment hash (EBANX unique identifier).
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// The payment hash Merchant Payment Code (unique merchant ID).
        /// </summary>
        [JsonProperty("merchant_payment_code")]
        public string MerchantPaymentCode { get; set; }
    }
}
