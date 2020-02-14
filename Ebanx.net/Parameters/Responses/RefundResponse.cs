using Ebanx.net.Parameters.Responses.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Responses
{
    /// <summary>
    /// 
    /// </summary>
    public class RefundResponse : ResponseBase
    {
        /// <summary>
        /// The ID of the refund on EBANX.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The ID of the refund on the merchant system (optional).
        /// </summary>
        [JsonProperty("merchant_refund_code")]
        public string MerchantRefundCode { get; set; }

        /// <summary>
        /// The status of the refund:
        /// RE(Requested) : The refund has been requested and is waiting to be processed.It can be cancelled while it has this status.
        /// PE (Pending): The refund is being processed. It cannot be cancelled anymore.
        /// CO (Confirmed): The refund was processed and the money was sent back to the customer.
        /// * CA (Cancelled): The refund was cancelled.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The date and hour when the refund was created.
        /// </summary>
        [JsonProperty("request_date")]
        public string RequestDate { get; set; }

        /// <summary>
        /// The date and hour when the customer data was received
        /// </summary>
        [JsonProperty("pending_date")]
        public string PendingDate { get; set; }

        /// <summary>
        /// The date and hour when the money was transferred to the customer.
        /// </summary>
        [JsonProperty("confirm_date")]
        public string ConfirmDate { get; set; }

        /// <summary>
        /// The refunded amount in the original currency.
        /// </summary>
        [JsonProperty("amount_ext")]
        public float AmountExt { get; set; }

        /// <summary>
        /// Description of the refund reason.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
