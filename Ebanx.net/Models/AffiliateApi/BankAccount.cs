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

        [JsonIgnore]
        public BankAccountTypes BankAccountType { get; set; }

        public enum BankAccountTypes
        {
            corrente,
            poupanca
        }

        /// <summary>
        /// information if the fields have been filled 
        /// </summary>
        [JsonIgnore]
        public bool IsValid
        {
            get
            {
                return string.IsNullOrEmpty(ValidateModel());
            }
        }

        /// <summary>
        /// Return message error if model is invalid
        /// </summary>
        /// <returns></returns>
        public string ValidateModel()
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(Number))
                error += "Número da conta não informado\n";

            if (string.IsNullOrEmpty(VerificationCode))
                error += "Dígito verificador não informado\n";

            if (string.IsNullOrEmpty(BankBranchCode))
                error += "Agência não informada\n";

            if (string.IsNullOrEmpty(BranchVerificationCode))
                error += "Dígito verificador da agência não informado\n";

            if (string.IsNullOrEmpty(BankIdentifier))
                error += "Banco não informado\n";

            return error;
        }

    }
}
