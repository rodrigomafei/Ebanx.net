using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Ebanx.net.Parameters.Requests.Base
{
    public class RequestBaseWithKey : RequestBase
    {
        /// <summary>
        /// Your unique and secret integration key.
        /// </summary>
        [JsonProperty("integration_key"), Required]
        public string IntegrationKey { get { return Start.Keys.Payment.StagIntegrationKey; } }

        /// <summary>
        /// Your unique and public integration key. You can do a token operation using this key instead of the integration key when the request is from the client of your customer (browser, app, etc…). By doing this, you don’t have to deal directly with the credit card information of your customer.
        /// </summary>
        [JsonProperty("public_integration_key"), Required]
        public string PublicIntegrationKey { get { return Start.Keys.Payment.StagPublicIntegrationKey; } }
    }
}
