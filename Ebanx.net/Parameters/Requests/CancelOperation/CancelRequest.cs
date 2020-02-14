using Ebanx.net.Parameters.Requests.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Parameters.Requests.CancelOperation
{
    /// <summary>
    /// 
    /// </summary>
    public class CancelRequest : RequestBaseWithKey
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hash"), Required, StringLength(48)]
        public string Hash { get; set; }
    }
}
