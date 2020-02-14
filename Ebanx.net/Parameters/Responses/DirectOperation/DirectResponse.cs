using Ebanx.net.Parameters.Responses.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Responses.DirectOperation
{
    /// <summary>
    /// 
    /// </summary>
    public class DirectResponse : ResponseBase
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("payment")]
        public PaymentResponse Payment { get; set; }
    }
}
