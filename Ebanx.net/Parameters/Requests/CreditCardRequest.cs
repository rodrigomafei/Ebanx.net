using Ebanx.net.Parameters.Requests.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ebanx.net.Parameters.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class CreditCardRequest : RequestBase
    {
        /// <summary>
        /// Credit card number.
        /// </summary>
        [JsonProperty("card_number"), Required, MinLength(14), MaxLength(19)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Credit card cardholder name.
        /// </summary>
        [JsonProperty("card_name"), Required, StringLength(64)]
        public string CardName { get; set; }

        /// <summary>
        /// Credit card due date (“valid thru”) in the format mm/yyyy.
        /// </summary>
        [JsonProperty("card_due_date"), Required, StringLength(7)]
        public string DueDate { get; set; }

        /// <summary>
        /// Credit card security code.
        /// </summary>
        [JsonProperty("card_cvv"), Required, MinLength(3), MaxLength(4)]
        public string CVV { get; set; }

        /// <summary>
        /// If true, the payment will be captured automatically by EBANX; if false, the payment will have to be captured by the merchant using the API method capture. The default value is true.
        /// </summary>
        [JsonProperty("auto_capture")]
        public bool AutoCapture { get; set; } = true;

        /// <summary>
        /// If a previously created token is informed, no credit card information is needed. EBANX will identify the credit card associated with the token and perform the transaction. Only available if you do recurring billing.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// check if the fields were filled
        /// </summary>
        public bool IsValid
        {
            get
            {
                if (
                    string.IsNullOrEmpty(CardName)
                    || string.IsNullOrEmpty(CardNumber)
                    || string.IsNullOrEmpty(CVV)
                    || string.IsNullOrEmpty(DueDate)
                   )
                    return false;

                return true;
            }
        }
    }

    public abstract class CreaditCardRequestExtention
    {
        public static CreditCardRequest GetACard(
            CreditCardTestRequestOperation operation = CreditCardTestRequestOperation.Valid,
            CreditCardTestType type = CreditCardTestType.Mastercard
            )
        {

            var c = new CreditCardRequest
            {
                CardNumber = "",
                CVV = "000",
                CardName = "Test Test",
                DueDate = "12/2027",
            };

            switch (operation)
            {
                case CreditCardTestRequestOperation.InsufficientFunds:
                    c.CardNumber = "4000000000000028";
                    break;
                case CreditCardTestRequestOperation.InvalidData:
                    c.CardNumber = "4000000000000002";
                    break;
                case CreditCardTestRequestOperation.Valid:
                default:
                    switch (type)
                    {
                        case CreditCardTestType.AmericanExpress:
                            c.CardNumber = "378282246310005";
                            break;
                        case CreditCardTestType.Aura:
                            c.CardNumber = "5078601870000127985";
                            break;
                        case CreditCardTestType.Discover:
                            c.CardNumber = "6011111111111117";
                            break;
                        case CreditCardTestType.Elo:
                            c.CardNumber = "6362970000457013";
                            break;
                        case CreditCardTestType.Hipercard:
                            c.CardNumber = "6062825624254001";
                            break;
                        case CreditCardTestType.Visa:
                            c.CardNumber = "4111111111111111";
                            break;
                        case CreditCardTestType.Mastercard:
                        default:
                            c.CardNumber = "5555555555554444";
                            break;
                    }
                    break;
            }

            return c;
        }

        public enum CreditCardTestRequestOperation
        {
            Valid,
            InsufficientFunds,
            InvalidData
        }

        public enum CreditCardTestType
        {
            AmericanExpress,
            Aura,
            Discover,
            Elo,
            Hipercard,
            Visa,
            Mastercard
        }
    }
}
