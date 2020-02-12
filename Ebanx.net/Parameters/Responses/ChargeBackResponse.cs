using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Responses
{
    public class ChargeBackResponse
    {
        /// <summary>
        /// The date and hour when the chargeback was imported into the system.
        /// </summary>
        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// The date and hour when the chargeback was created by the acquirer on behalf of the customer.
        /// </summary>
        [JsonProperty("chargeback_date")]
        public string ChargebackDate { get; set; }

        /// <summary>
        /// Description of the chargeback.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Flag that shows if a chargeback credit was issued.
        /// </summary>
        [JsonProperty("chargeback_credit")]
        public bool ChargebackCredit { get; set; }
    }
}
