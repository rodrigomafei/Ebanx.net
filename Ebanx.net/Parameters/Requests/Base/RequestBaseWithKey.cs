using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Ebanx.net.Parameters.Requests.Base
{
    /// <summary>
    /// 
    /// </summary>
    public class RequestBaseWithKey : RequestBase
    {
        /// <summary>
        /// Your unique and secret integration key.
        /// </summary>
        [JsonProperty("integration_key")]
        public string IntegrationKey
        {
            get
            {
                if (Config.Keys == null)
                    return string.Empty;

                return Config.Environment == Api.Shared.EbanxAPIEnvironment.Staging ? Config.Keys.PaymentKeys.StagIntegrationKey : Config.Keys.PaymentKeys.ProdIntegrationKey;
            }
        }

        /// <summary>
        /// Your unique and public integration key. You can do a token operation using this key instead of the integration key when the request is from the client of your customer (browser, app, etc…). By doing this, you don’t have to deal directly with the credit card information of your customer.
        /// </summary>
        [JsonProperty("public_integration_key")]
        private string PublicIntegrationKey 
        { 
            get 
            {
                if (Config.Keys == null)
                    throw new ArgumentException("Ebanx keys not informed");

                return Config.Environment == Api.Shared.EbanxAPIEnvironment.Staging ? Config.Keys.PaymentKeys.StagPublicIntegrationKey : Config.Keys.PaymentKeys.ProdPublicIntegrationKey; 
            } 
        }
    }

    public class RequestAffiliateBaseWithKey
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Authorization")]
        public string AffiliateKey
        {
            get
            {
                if (Config.Keys == null)
                    return string.Empty;

                return Config.Environment == Api.Shared.EbanxAPIEnvironment.Staging ? Config.Keys.AffiliateKeys.StagIntegrationKey : Config.Keys.AffiliateKeys.ProdIntegrationKey;

            }
        }
    }
}
