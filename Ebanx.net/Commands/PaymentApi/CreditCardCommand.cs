using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Commands.PaymentApi
{
    public class CreditCardCommand
    {
        /// <summary>
        /// Credit card number.
        /// </summary>
        [JsonProperty("card_number")]
        public string CardNumber { get; set; }

        /// <summary>
        /// Credit card cardholder name.
        /// </summary>
        [JsonProperty("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// Credit card due date (“valid thru”) in the format mm/yyyy.
        /// </summary>
        [JsonProperty("card_due_date")]
        public string DueDate { get; set; }

        /// <summary>
        /// Credit card security code.
        /// </summary>
        [JsonProperty("card_cvv")]
        public string CVV { get; set; }

        /// <summary>
        /// If true, the payment will be captured automatically by EBANX; if false, the payment will have to be captured by the merchant using the API method capture. The default value is true.
        /// </summary>
        [JsonProperty("auto_capture")]
        public bool AutoCapture { get; set; } = true;

        /// <summary>
        /// If a previously created token is informed, no credit card information is needed. EBANX will identify the credit card associated with the token and perform the transaction. Only available if you do recurring billing.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// check if the fields were filled
        /// </summary>
        public bool IsValid 
        {
            get
            {
                if (
                    string.IsNullOrEmpty(CardName)
                    || string.IsNullOrEmpty(CardNumber)
                    || string.IsNullOrEmpty(CVV)
                    || string.IsNullOrEmpty(DueDate)
                   )
                    return false;

                return true;
            }
        }
    }
}
