using Ebanx.net.Parameters.Responses.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Parameters.Responses.RefundOperation
{
    /// <summary>
    /// 
    /// </summary>
    public class RefundResponse : ResponseBase
    {
        [JsonProperty("payment")]
        public PaymentResponse Payment { get; set; }
    }
}
