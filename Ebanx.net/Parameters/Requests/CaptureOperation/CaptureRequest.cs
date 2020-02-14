using Ebanx.net.Parameters.Requests.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Parameters.Requests.CaptureOperation
{
    /// <summary>
    /// 
    /// </summary>
    public class CaptureRequest : RequestBaseWithKey
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

        /// <summary>
        /// Optional identifier for the payment capture.
        /// </summary>
        [JsonProperty("merchant_capture_code")]
        public string MerchantCaptureCode { get; set; }

        /// <summary>
        /// The amount of the partial capture. You can make only one partial capture per authorized payment. If you want to enable this feature, please contact our Integration Team.
        /// </summary>
        [JsonProperty("amount")]
        public float Amount { get; set; }
    }
}
