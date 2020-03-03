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
    }
}
