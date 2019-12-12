using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Commands.PaymentApi
{
    public class DirectCommand : BaseCommand
    {
        /// <summary>
        /// Your unique and secret integration key.
        /// </summary>
        [JsonProperty("integration_key")]
        public string IntegrationKey { get
            {
                switch (Environment)
                {
                    default:
                    case Helpers.EbanxUrlHelper.APIEnvironment.Prod:
                        return Parameters.ProdIntegrationKey;

                    case Helpers.EbanxUrlHelper.APIEnvironment.Stag:
                        return Parameters.StagIntegrationKey;
                }
            }
        }

        /// <summary>
        /// Must be <b>request.</b>
        /// </summary>
        [JsonProperty("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Currently only <b>full</b> mode is available.
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// A JSON object that represents the payment.
        /// </summary>
        [JsonProperty("payment")]
        public DirectPayment Payment { get; set; }

        /// <summary>
        /// Optional parameter to tell EBANX to redirect the customer straight to the response URL after the payment is completed.
        /// <para>This can be used in cases where the merchant will provide all the payment information in the response URL page.</para>
        /// <para>If this parameter is passed and equals to true then EBANX will not display the payment completed screen and will redirect the customer straight to the response URL, where the merchant must provide all the payment information.</para>
        /// <para>If the parameter is not provided or its value is not true, the payment completed screen will be displayed.</para>
        /// </summary>
        [JsonProperty("bypass_boleto_screen")]
        public bool BypassBoletoScreen { get; set; }


    }

    public class DirectPayment
    {
        public DirectPayment()
        {
            Items = new List<ItemCommand>();
        }

        /// <summary>
        /// Customer name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Customer email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Three-letter code of the payment currency. Supported currencies:
        /// * BRL
        /// </summary>
        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The amount in the specified currency (currency_code). E.g.: 100.50
        /// </summary>
        [JsonProperty("amount_total")]
        public float AmountTotal { get; set; }

        /// <summary>
        /// The payment hash Merchant Payment Code (unique merchant ID).
        /// </summary>
        [JsonProperty("merchant_payment_code")]
        public string MerchantPaymentCode { get; set; }

        /// <summary>
        /// The code of the payment method. The supported codes are:
        /// <list type="bullet">
        /// <item><b>amex:</b> American Express credit card.</item>
        /// <item><b>boleto:</b> Boleto bancário.</item>
        /// <item><b>diners:</b> Diners credit card.</item>
        /// <item><b>discover:</b>  Discover credit card.</item>
        /// <item><b>elo:</b> Elo credit card.</item>
        /// <item><b>hipercard:</b> Hipercard credit card.</item>
        /// <item><b>mastercard:</b> MasterCard credit card.</item>
        /// <item><b>visa:</b> Visa credit card.</item>
        /// </list>
        /// </summary>
        [JsonProperty("payment_type_code")]
        public string TypeCode { get; set; }

        /// <summary>
        /// Customers document.
        ///<para>* Brazil: requires a valid CPF(natural person taxpayer ID) or CNPJ(business taxpayer ID).</para>
        /// </summary>
        [JsonProperty("document")]
        public string Document { get; set; }

        /// <summary>
        /// Customer’s IP adress. It may be used by an anti-fraud tool.
        /// </summary>
        [JsonProperty("customer_ip")]
        public string CustomerIp { get; set; }

        /// <summary>
        /// Customer’s zipcode.
        /// <para>* Brazil: required.</para>
        /// </summary>
        [JsonProperty("zipcode")]
        public string ZipCode { get; set; }

        /// <summary>
        /// Customer address (street name).
        /// <para>* Brazil: required.</para>
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Customer street number.
        /// <para>* Brazil: required.</para>
        /// </summary>
        [JsonProperty("street_number")]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Extra address field for complimentary data.
        /// </summary>
        [JsonProperty("street_complement")]
        public string StreetComplement { get; set; }

        /// <summary>
        /// Customer city.
        /// <para>* Brazil: required.</para>
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Customer state/region/province.
        /// <para>* Brazil: required.</para>
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The two-letter country code for the customer country. The available codes are:
        /// <para>* <b>br</b>: Brazil.</para>
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Customer phone number. It is required for all countries.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        ///Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the “response_url“ when the transaction is finished.
        /// </summary>
        [JsonProperty("user_value_1")]
        public string UserValue1 { get; set; }

        /// <summary>
        ///Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the “response_url“ when the transaction is finished.
        /// </summary>
        [JsonProperty("user_value_2")]
        public string UserValue2 { get; set; }

        /// <summary>
        ///Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the “response_url“ when the transaction is finished.
        /// </summary>
        [JsonProperty("user_value_3")]
        public string UserValue3 { get; set; }

        /// <summary>
        ///Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the “response_url“ when the transaction is finished.
        /// </summary>
        [JsonProperty("user_value_4")]
        public string UserValue4 { get; set; }

        /// <summary>
        ///Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the “response_url“ when the transaction is finished.
        /// </summary>
        [JsonProperty("user_value_5")]
        public string UserValue5 { get; set; }

        /// <summary>
        /// he due date of payments slips. Boletos issued in USD can have a maximum expiry period of three days; boletos issued in BRL can have an extended expiry date. The due date is based on local time of the country that the payment is generated.
        /// </summary>
        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        /// <summary>
        /// Generates a token for recurring billing. This is only available for merchants that have requested recurring billing on their contracts.
        /// </summary>
        [JsonProperty("create_token")]
        public bool CreateToken { get; set; }

        /// <summary>
        /// Choose the token you want to use for recurring billing. This is only available for merchants that have requested recurring billing on their contracts. Use this parameter only if <b>create_token </b>is true.
        /// <para><b>NOTE: TOKENS EXPIRE AFTER 14 MONTHS OF ITS LAST USE.</b></para>
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// The number of instalments of the payment (from 1 to 12, depending on your contract and the country).
        /// <para>* <b>Brazil</b>: 1 to 12 (depending on your contract).</para>
        /// </summary>
        [JsonProperty("instalments")]
        public int Instalments { get; set; }

        /// <summary>
        /// Object containing the customers credit card information.
        /// </summary>
        [JsonProperty("creditcard")]
        public CreditCardCommand CreditCard { get; set; }

        /// <summary>
        /// A note about the payment. The value of this parameter will be shown along with payment details.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// The object containing the sub account’s name. Required for payments where the sub account feature is being used.
        /// </summary>
        [JsonProperty("sub_account")]
        public SubAccountCommand SubAccount { get; set; }

        /// <summary>
        /// Object containing the items of the order
        /// </summary>
        [JsonProperty("items")]
        public IList<ItemCommand> Items { get; set; }

        /// <summary>
        /// Code for the customer’s bank. <b>Only required for Colombia payments.</b> You can retrieve the available codes from ws/getBankList operation.
        /// </summary>
        [JsonProperty("eft_code")]
        public string EftCode { get; set; }

        /// <summary>
        /// The URL to send notifications for this payment. If this field is filled, EBANX will notify using this URL instead of the configured one.
        /// <para>Example: https://notify.example.com/ </para>
        /// </summary>
        [JsonProperty("notification_url")]
        public string NotificationUrl { get; set; }

        /// <summary>
        /// The URL to redirect the customer after the payment in the EBANX Payment Page. If this field is filled, EBANX will redirect the customer using this URL instead of the configured one.
        /// <para>Example: https://mywebsite.com/thankyou </para>
        /// </summary>
        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Optional parameter that can be used to identify the type of customer:
        /// <para><b>business:</b>Corporation, legal entity.</para>
        /// <para><b>*personal:</b> Natural person.</para>
        /// </summary>
        [JsonProperty("person_type")]
        
        public string PersonType { get
            {
                var docNumber = Document ?? string.Empty;

                docNumber = docNumber.Replace(".", "");
                docNumber = docNumber.Replace("-", "");
                docNumber = docNumber.Replace("/", "");

                if (docNumber.Length == 14)
                    return "business";

                return string.Empty;
            }
        }

        /// <summary>
        /// A JSON object that represents the responsible. Required if person_type = business.
        /// </summary>
        [JsonProperty("responsible")]
        public ResponsibleCommand Responsible { get; set; }

    }

    

}
