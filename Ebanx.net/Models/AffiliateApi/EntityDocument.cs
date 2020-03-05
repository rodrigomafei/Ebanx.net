using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ebanx.net.Models.Country;

namespace Ebanx.net.Models.AffiliateApi
{
    public class EntityDocument
    {
        [JsonProperty("country")]
        private string Country 
        {
            get
            {
                return CountryCode.ToString();
            }
        }

        public CountryCodes CountryCode { get; set; }
        [JsonProperty("number")]
        public string Number { get; set; }
        [JsonProperty("type")]
        private string Type 
        {
            get
            {
                return DocumentType.ToString();
            }
        }

        public DocumentTypes DocumentType { get; set; }

        public enum DocumentTypes
        {
            passport,
            driving_licence,
            national_identity_card,
            cpf,
            cnpj,
            others
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
                error += "Número do documento não informado\n";

            return error;
        }
    }
}
