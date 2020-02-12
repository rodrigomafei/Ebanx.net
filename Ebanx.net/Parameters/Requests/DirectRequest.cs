using Ebanx.net.Parameters.Requests.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Requests
{
    public class DirectRequest : RequestBaseWithKey
    {
        public DirectRequest(string _operation, string _mode)
        {
            Operation = _operation;
            Mode = _mode;
        }

        /// <summary>
        /// Must be request.
        /// </summary>
        [JsonProperty("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Currently only full mode is available.
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// A JSON object that represents the payment.
        /// </summary>
        [JsonProperty("payment")]
        public PaymentRequest Payment { get; set; }

        /// <summary>
        /// Optional parameter to tell EBANX to redirect the customer straight to the response URL after the payment is completed.
        /// This can be used in cases where the merchant will provide all the payment information in the response URL page.
        /// If this parameter is passed and equals to true then EBANX will not display the payment completed screen and will redirect the customer straight to the response URL, where the merchant must provide all the payment information.
        /// If the parameter is not provided or its value is not true, the payment completed screen will be displayed.
        /// </summary>
        [JsonProperty("bypass_boleto_screen")]
        public bool BypassBoletoScreen { get; set; }
    }
}
