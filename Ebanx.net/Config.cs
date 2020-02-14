using Ebanx.net.Api.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ebanx.net
{
    /// <summary>
    /// Ebanx start configuration
    /// </summary>
    public static class Config
    {
        /// <summary>
        /// Default is staging
        /// </summary>
        public static EbanxAPIEnvironment Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static EbanxKeys Keys { get; set; } = new EbanxKeys();
        
    }

    /// <summary>
    /// Integrations keys from Ebanx
    /// </summary>
    public class EbanxKeys
    {
        /// <summary>
        /// 
        /// </summary>
        public EbanxKeys()
        {
            Payment = new PaymentKey();
            Affiliate = new AffiliateKey();
        }

        public PaymentKey Payment { get; set; }
        public AffiliateKey Affiliate { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class PaymentKey
    {
        /// <summary>
        /// Your unique and secret integration key.
        /// </summary>
        public string ProdIntegrationKey { get; set; }

        public string ProdPublicIntegrationKey { get; set; }

        /// <summary>
        /// Your unique and secret integration key.
        /// </summary>
        public string StagIntegrationKey { get; set; }

        public string StagPublicIntegrationKey { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class AffiliateKey
    {
        /// <summary>
        /// Your unique and secret integration key.
        /// </summary>
        public string ProdIntegrationKey { get; set; }

        /// <summary>
        /// Your unique and secret integration key.
        /// </summary>
        public string StagIntegrationKey { get; set; }
    }
}
