using Ebanx.net.Parameters.Responses.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Parameters.Responses.CaptureOperation
{
    /// <summary>
    /// 
    /// </summary>
    public class CaptureResponse : ResponseBase
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("payment")]
        public PaymentResponse Payment { get; set; }
    }
}
