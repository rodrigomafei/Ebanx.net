using Ebanx.net.Parameters.Requests.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Parameters.Requests.RefundOrCancelOperation
{
    /// <summary>
    /// 
    /// </summary>
    public class RefundOrCancelRequest : RequestBaseWithKey
    {
        /// <summary>
        /// The payment hash (EBANX unique identifier).
        /// </summary>
        [JsonProperty("hash"), StringLength(48), Required]
        public string Hash { get; set; }

        /// <summary>
        /// Description of the refund reason.
        /// </summary>
        [JsonProperty("description"), MinLength(1), MaxLength(1500), Required]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the refund on the merchant system.
        /// </summary>
        [JsonProperty("merchant_refund_code"), MinLength(1), MaxLength(20)]
        public string MerchantRefundCode { get; set; }
    }
}
