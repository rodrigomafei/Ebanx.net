using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Models.AffiliateApi
{
    public class Contact
    {
        [JsonProperty("contact_name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mobile_phone_number")]
        public string MobilePhoneNumber { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }
}
