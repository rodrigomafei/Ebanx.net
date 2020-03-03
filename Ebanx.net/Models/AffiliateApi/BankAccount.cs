using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Models.AffiliateApi
{
    /// <summary>
    /// A Bank Account object is a real bank account where the available receivables will be payed out.
    /// </summary>
    public class BankAccount
    {
        [JsonProperty("account_number")]
        public string Number { get; set; }

        [JsonProperty("account_verification_code")]
        public string VerificationCode { get; set; }

        [JsonProperty("bank_branch_code")]
        public string BankBranchCode { get; set; }

        [JsonProperty("bank_identifier")]
        public string BankIdentifier { get; set; }

        [JsonProperty("branch_verification_code")]
        public string BranchVerificationCode { get; set; }

        [JsonProperty("bank_account_type")]
        private string AccountType 
        {
            get
            {
                return BankAccountType.ToString();
            }
        }

        public BankAccountTypes BankAccountType { get; set; }

        public enum BankAccountTypes
        {
            corrente, 
            poupanca
        }
    }
}
