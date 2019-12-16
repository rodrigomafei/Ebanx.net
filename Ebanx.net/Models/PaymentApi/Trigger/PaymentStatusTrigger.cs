using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Models.PaymentApi.Trigger
{
    public class PaymentStatusTrigger
    {
        [JsonProperty("operation")]
        public string Operation { get; set; }
        [JsonProperty("hash_codes")]
        public string Hash { get; set; }
        [JsonProperty("notification_type")]
        public string Type { get; set; }
    }
}
