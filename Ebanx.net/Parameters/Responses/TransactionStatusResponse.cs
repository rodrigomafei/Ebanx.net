using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Responses
{
    public class TransactionStatusResponse
    {
        /// <summary>
        /// The acquirer that processed the transaction.
        /// </summary>
        [JsonProperty("acquirer")]
        public string Acquirer { get; set; }

        /// <summary>
        /// The transaction status code:
        /// OK: The transaction amount was approved.
        /// NOK: The acquirer did not approved the transaction.The customer must contact the issuer to check for any issue with his credit card.
        /// RETRY: Something went wrong with the process. You can retry with the same data.We recommend you to try more 3 times on different periods of time (first try, then second try after 2 hours after the first, etc).
        /// You can see more of these status HERE.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// The description for the status code, which is returned from the acquirer.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Transaction authentication code in the acquirer.
        /// </summary>
        [JsonProperty("authcode")]
        public string Authcode { get; set; }
    }
}
