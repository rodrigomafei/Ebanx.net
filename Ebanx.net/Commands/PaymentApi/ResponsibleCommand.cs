using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Commands.PaymentApi
{
    public class ResponsibleCommand
    {
        /// <summary>
        /// Responsible name. Required if person_type = business.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
