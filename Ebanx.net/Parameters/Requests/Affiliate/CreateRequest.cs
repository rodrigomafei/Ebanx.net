using Ebanx.net.Models.AffiliateApi;
using Ebanx.net.Parameters.Requests.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ebanx.net.Models.Country;

namespace Ebanx.net.Parameters.Requests.Affiliate
{
    /// <summary>
    /// A Recipient object describe a person or a company that receives the available amount processed with us.
    /// </summary>
    public class CreateRequest : RequestAffiliateBaseWithKey
    {
        public CreateRequest()
        {
            BankAccounts = new List<BankAccount>();
            Contacts = new List<Contact>();
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        private string Type 
        {
            get
            {
                return RecipientType.ToString();
            }
        }

        public RecipientTypes RecipientType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("country")]
        private string Country 
        {
            get
            {
                return CountryCode.ToString();
            }
        }


        public CountryCodes CountryCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("document")]
        public EntityDocument Document { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A Contact object describe the main ways to contact a person.
        /// </summary>
        [JsonProperty("contacts")]
        public IList<Contact> Contacts { get; set; }

        /// <summary>
        /// A Bank Account object is a real bank account where the available receivables will be payed out.
        /// </summary>
        [JsonProperty("bank_accounts")]
        public IList<BankAccount> BankAccounts { get; set; }

        /// <summary>
        /// You can supply your own reference to a recipient.
        /// </summary>
        [JsonProperty("customer_ref")]
        public string CustomerReference { get; set; }

        public enum RecipientTypes
        {
            individual,
            company
        }
    }
}
