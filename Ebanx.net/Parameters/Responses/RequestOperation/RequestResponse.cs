﻿using Ebanx.net.Parameters.Responses.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Parameters.Responses.RequestOperation
{
    /// <summary>
    /// 
    /// </summary>
    public class RequestResponse : ResponseBase
    {
        /// <summary>
        /// A JSON object that represents the payment.
        /// </summary>
        [JsonProperty("payment")]
        public PaymentResponse Payment { get; set; }
    }
}
