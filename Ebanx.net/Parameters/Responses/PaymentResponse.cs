using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebanx.net.Parameters.Responses
{
    public class PaymentResponse
    {
        /// <summary>
        /// The payment hash (EBANX unique identifier).
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// The payment PIN (EBANX and Customer unique identifier).
        /// </summary>
        [JsonProperty("pin")]
        public string Pin { get; set; }

        /// <summary>
        /// The country of the payment.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The payment hash Merchant Payment Code (unique merchant ID).
        /// </summary>
        [JsonProperty("merchant_payment_code")]
        public string MerchantPaymentCode { get; set; }

        /// <summary>
        /// The order number, optional identifier set by the merchant. You can have multiple payments with the same order number.
        /// </summary>
        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// The payment status. The following statuses are available:
        /// OP: the customer has not yet filled the payment details on the EBANX Checkout.It can change either to CA(time out) or PE.
        /// PE: the payment is pending confirmation. It can change either to CA or CO.
        /// CO: the payment is confirmed (paid).
        // /CA: the payment is cancelled.
        // </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The date and hour of the last status change.
        /// </summary>
        [JsonProperty("status_date")]
        public string StatusDate { get; set; }

        /// <summary>
        /// The date and hour of when the payment was created.
        /// </summary>
        [JsonProperty("open_date")]
        public string OpenDate { get; set; }

        /// <summary>
        /// The date and hour of when the payment was confirmed.
        /// </summary>
        [JsonProperty("confirm_date")]
        public string ConfirmDate { get; set; }

        /// <summary>
        /// The date and hour of when the payment was settled.
        /// </summary>
        [JsonProperty("transfer_date")]
        public string TransferDate { get; set; }

        /// <summary>
        /// The amount in local currency.
        /// </summary>
        [JsonProperty("amount_br")]
        public float AmountBr { get; set; }

        /// <summary>
        /// The tax amount in local currency (varies between countries).
        /// </summary>
        [JsonProperty("amount_iof")]
        public float AmountIof { get; set; }

        /// <summary>
        /// The amount in the original currency.
        /// </summary>
        [JsonProperty("amount_ext")]
        public float AmountExt { get; set; }

        /// <summary>
        /// The exchange rate used in the payment.
        /// </summary>
        [JsonProperty("currency_rate")]
        public float CurrencyRate { get; set; }

        /// <summary>
        /// Three-letter code of the original currency.
        /// </summary>
        [JsonProperty("currency_ext")]
        public string CurrencyExt { get; set; }

        /// <summary>
        /// Expiry date of the payment (not applicable to all payment methods).
        /// </summary>
        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        /// <summary>
        /// Number of instalments for the payment, default value is 1.
        /// </summary>
        [JsonProperty("instalments")]
        public int Instalments { get; set; }

        /// <summary>
        /// The code of the payment method. The supported codes are:
        /// amex: American Express credit card.
        /// boleto: Boleto bancário.
        /// diners: Diners credit card.
        /// discover: Discover credit card.
        /// elo: Elo credit card.
        /// hipercard: Hipercard credit card.
        /// mastercard: MasterCard credit card.
        /// visa: Visa credit card.
        /// </summary>
        [JsonProperty("payment_type_code")]
        public string PaymentTypeCode { get; set; }

        /// <summary>
        /// A JSON object that represents the payment details.
        /// </summary>
        [JsonProperty("details")]
        public DetailsResponse Details { get; set; }

        /// <summary>
        /// A JSON object that represents the payment credit card transaction.
        /// </summary>
        [JsonProperty("transaction_status")]
        public TransactionStatusResponse TransactionStatus { get; set; }

        /// <summary>
        /// Flag that shows if a payment is pre-approved by the credit card acquirer.
        /// </summary>
        [JsonProperty("pre_approved")]
        public bool PreApproved { get; set; }

        /// <summary>
        /// Flag that shows if a payment is ready to be captured. Applies only to credit cards when auto_capture is set to false. Some remarks on this attribute:
        /// A payment can only be captured if pre_approved value is true, which means that the payment has been pre approved by the credit card acquirer.
        /// Before capture, an authorized payment has status as PE(pending). After the capture, the status changes to CO(confirmed).
        /// A payment can only be captured if the status is PE(pending).
        /// *Payments must be captured in 4 (four) days, otherwise they are automatically cancelled.
        /// NOTE: It can be changed up to 5 (five) days.
        /// </summary>
        [JsonProperty("capture_available")]
        public bool? CaptureAvailable { get; set; }

        /// <summary>
        /// The URL the customer should be redirected to. Applies to certain payment methods using the Direct API.
        /// </summary>
        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// If the customer has an EBANX Account profile and it has balance enough to pay for the created boleto, the response will contain this parameter responsible for redirecting the customer to his EBANX Account page so he can pay the boleto with his available balance.
        /// </summary>
        [JsonProperty("pay_with_balance_url")]
        public string PayWithBalanceUrl { get; set; }

        /// <summary>
        /// The boleto URL.
        /// </summary>
        [JsonProperty("boleto_url")]
        public string BoletoUrl { get; set; }

        /// <summary>
        /// The boleto barcode number. (Boleto)
        /// </summary>
        [JsonProperty("boleto_barcode")]
        public string BoletoBarcode { get; set; }

        /// <summary>
        /// The CIP URL. (PagoEfectivo)
        /// </summary>
        [JsonProperty("cip_url")]
        public string CipUrl { get; set; }

        /// <summary>
        /// The CIP code. (PagoEfectivo)
        /// </summary>
        [JsonProperty("cip_code")]
        public string CipCode { get; set; }

        /// <summary>
        /// An array of objects that represent a refund linked to this payment. This node will only be present if a refund was issued.
        /// </summary>
        [JsonProperty("refunds")]
        public List<RefundResponse> Refunds { get; set; }

        /// <summary>
        /// A JSON object that represents a chargeback linked to this payment. This node will only be present if a chargeback was issued.
        /// </summary>
        [JsonProperty("chargeback")]
        public ChargeBackResponse Chargeback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PaymentStatusEnum PaymentStatus
        {
            get
            {
                try
                {
                    switch (Status)
                    {
                        case "CO": return PaymentStatusEnum.Confirmed;
                        case "OP": return PaymentStatusEnum.Open;
                        case "PE": return PaymentStatusEnum.Pending;
                        case "CA": return PaymentStatusEnum.Cancelled;
                        default: return PaymentStatusEnum.Unknown;
                    }

                }

                catch (Exception e)
                {
                    return PaymentStatusEnum.Unknown;
                }
            }
        }

        /// <summary>
        /// <para><b>(Open) OP:</b> the customer has not yet filled the payment details on the EBANX Checkout. It can change either to CA (time out) or PE.</para>
        /// <para><b>(Pending) PE:</b> the payment is pending confirmation. It can change either to CA or CO.</para>
        /// <para><b>(Confirmed) CO:</b> the payment is confirmed (paid).</para>
        /// <para><b>(Cancelled) CA:</b> the payment is cancelled.</para>
        /// </summary>
        public enum PaymentStatusEnum
        {
            /// <summary>
            /// 
            /// </summary>
            Unknown,
            /// <summary>
            /// 
            /// </summary>
            Open,
            /// <summary>
            /// 
            /// </summary>
            Pending,
            /// <summary>
            /// 
            /// </summary>
            Confirmed,
            /// <summary>
            /// 
            /// </summary>
            Cancelled
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsPaid
        {
            get
            {
                return PaymentStatus == PaymentStatusEnum.Confirmed;
            }
        }
    }
}
