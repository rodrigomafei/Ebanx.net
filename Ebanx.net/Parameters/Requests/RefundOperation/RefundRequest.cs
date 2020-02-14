using Ebanx.net.Parameters.Requests.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Parameters.Requests.RefundOperation
{
    /// <summary>
    /// 
    /// </summary>
    public class RefundRequest : RequestBaseWithKey
    {
        /// <summary>
        /// The available operations are:
        /// request: request a new refund.
        /// cancel: cancel a refund.
        /// </summary>
        [JsonProperty("operation"), Required, MinLength(6), MaxLength(7)]
        public string Operation { get; set; }

        /// <summary>
        /// The payment hash (EBANX unique identifier).
        /// </summary>
        [JsonProperty("hash"), StringLength(48)]
        public string Hash { get; set; }

        /// <summary>
        /// The amount to be refunded; expressed in the original payment currency.
        /// </summary>
        [JsonProperty("amount")]
        public float Amount { get; set; }

        /// <summary>
        /// Description of the refund reason.
        /// </summary>
        [JsonProperty("description"), MinLength(1), MaxLength(1500)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the refund on the merchant system.
        /// </summary>
        [JsonProperty("merchant_refund_code"), MinLength(1), MaxLength(20)]
        public string MerchantRefundCode { get; set; }

        /// <summary>
        /// The ID of the refund to be cancelled.
        /// </summary>
        [JsonProperty("refund_id")]
        public int RefundId { get; set; }
    }
}
