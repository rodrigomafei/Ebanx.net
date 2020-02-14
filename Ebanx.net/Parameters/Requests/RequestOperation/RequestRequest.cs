using Ebanx.net.Parameters.Requests.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Parameters.Requests.RequestOperation
{
    /// <summary>
    /// 
    /// </summary>
    public class RequestRequest : RequestBaseWithKey
    {
        /// <summary>
        /// Customer name.
        /// </summary>
        [JsonProperty("name"), Required]
        public string Name { get; set; }

        /// <summary>
        /// Customer email address.
        /// </summary>
        [JsonProperty("email"), Required]
        public string Email { get; set; }

        /// <summary>
        /// Three-letter code of the payment currency. Supported currencies:
        /// BRL
        /// </summary>
        [JsonProperty("currency_code"), Required]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The amount in the specified currency (currency_code). E.g.: 100.50
        /// </summary>
        [JsonProperty("amount"), Required]
        public float Amount { get; set; }

        /// <summary>
        /// The payment hash Merchant Payment Code (merchant unique ID).
        /// </summary>
        [JsonProperty("merchant_payment_code"), MinLength(1), MaxLength(40)]
        public string MerchantPaymentCode { get; set; }

        /// <summary>
        /// The order number, optional identifier set by the merchant. You can have multiple payments with the same order number.
        /// </summary>
        [JsonProperty("order_number"), MinLength(1), MaxLength(40)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// The code of the payment method. The supported codes are:
        /// amex: American Express credit card(Brazil).
        /// boleto: Boleto bancário(Brazil).
        /// discover: Discover credit card(Brazil).
        /// elo: Elo credit card(Brazil).
        /// hipercard: Hipercard credit card(Brazil).
        /// mastercard: MasterCard credit card(Brazil).
        /// visa: Visa credit card(Brazil).
        /// </summary>
        [JsonProperty("payment_type_code"), Required, StringLength(32)]
        public string PaymentTypeCode { get; set; }

        /// <summary>
        /// Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the response_url when the transaction is finished.
        /// </summary>
        [JsonProperty("user_value_1"), MinLength(1), MaxLength(20)]
        public string UserValue1 { get; set; }

        /// <summary>
        /// Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the response_url when the transaction is finished.
        /// </summary>
        [JsonProperty("user_value_2"), MinLength(1), MaxLength(20)]
        public string UserValue2 { get; set; }

        /// <summary>
        /// Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the response_url when the transaction is finished.
        /// </summary>
        [JsonProperty("user_value_3"), MinLength(1), MaxLength(20)]
        public string UserValue3 { get; set; }

        /// <summary>
        /// Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the response_url when the transaction is finished.
        /// </summary>
        [JsonProperty("user_value_4"), MinLength(1), MaxLength(20)]
        public string UserValue4 { get; set; }

        /// <summary>
        /// Optional parameters that can be used by the merchant associate additional info to the payment. These parameters will be appended to the response_url when the transaction is finished.
        /// </summary>
        [JsonProperty("user_value_5"), MinLength(1), MaxLength(20)]
        public string UserValue5 { get; set; }

        /// <summary>
        /// The URL to send notifications for this payment. If this field is filled, EBANX will notify using this URL instead of the configured one.
        /// Example: https://notify.example.com/
        /// </summary>
        [JsonProperty("notification_url"), MinLength(1), MaxLength(2000)]
        public string NotificationUrl { get; set; }

        /// <summary>
        /// Optional parameter to tell EBANX to redirect the customer straight to the response URL after the payment is completed. This can be used in cases where the merchant will provide all the payment information in the response URL page.
        /// If this parameter is passed and equals to true then EBANX will not display the payment completed screen and will redirect the customer straight to the response URL, where the merchant must provide all the payment information.If the parameter is not provided or its value is not true, the payment completed screen will be displayed.
        /// </summary>
        [JsonProperty("bypass_boleto_screen")]
        public bool BypassBoletoScreen { get; set; }

        /// <summary>
        /// Customer zipcode. If provided, the information will be displayed in the EBANX Payment Page.
        /// </summary>
        [JsonProperty("zipcode"), StringLength(8)]
        public string Zipcode { get; set; }

        /// <summary>
        /// Customer address (street name). If provided, the information will be displayed in the EBANX Payment Page.
        /// </summary>
        [JsonProperty("address"), MinLength(1), MaxLength(100)]
        public string Address { get; set; }

        /// <summary>
        /// Customer street number. If provided, the information will be displayed in the EBANX Payment Page.
        /// </summary>
        [JsonProperty("street_number"), MinLength(1), MaxLength(30)]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Customer city. If provided, the information will be displayed in the EBANX Payment Page.
        /// </summary>
        [JsonProperty("city"), MinLength(1), MaxLength(80)]
        public string City { get; set; }

        /// <summary>
        /// Customer state/region/province. If provided, the information will be displayed in the EBANX Payment Page.
        /// </summary>
        [JsonProperty("state"), MinLength(2), MaxLength(5)]
        public string State { get; set; }

        /// <summary>
        /// The two-letter country code for the customer country. The available codes are:
        /// br: Brazil.
        /// /// </summary>
        [JsonProperty("country"), StringLength(2)]
        public string Country { get; set; }

        /// <summary>
        /// Customer phone number. If provided, the information will be displayed in the EBANX Payment Page.
        /// </summary>
        [JsonProperty("phone_number"), MinLength(10), MaxLength(15)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The due date of payments slips. Due date for boleto payments in the format dd/mm/yyyy. The maximum expiry date will depend on your merchant account settings.The due date is based on the local time of the country that the payment is generated.
        /// </summary>
        [JsonProperty("due_date"), StringLength(10)]
        public string DueDate { get; set; }

        /// <summary>
        /// The name of the sub account
        /// </summary>
        [JsonProperty("sub_acc_name"), StringLength(32)]
        public string SubAccName { get; set; }

        /// <summary>
        /// The URL of the logo of the sub account. OBS: It MUST be a HTTPS URL, otherwise, you will receive and error message.
        /// </summary>
        [JsonProperty("sub_acc_image_url"), StringLength(200)]
        public string SubAccImageUrl { get; set; }

        /// <summary>
        /// Number or Range of instalments. OBS: If your are sending a range, must be in the format “X-Y”. Example: “1-6”.
        /// </summary>
        [JsonProperty("instalments"), StringLength(5)]
        public string Instalments { get; set; }
    }
}
