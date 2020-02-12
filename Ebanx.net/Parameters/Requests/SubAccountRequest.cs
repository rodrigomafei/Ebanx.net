using Ebanx.net.Parameters.Requests.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Requests
{
    public class SubAccountRequest : RequestBase
    {
        /// <summary>
        /// Name of the sub account
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// URL of the logo of the sub-account. PS: It MUST be an HTTPS URL. Otherwise, you will receive an error message.
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }
}
