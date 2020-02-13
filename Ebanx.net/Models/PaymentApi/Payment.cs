//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Ebanx.net.Models.PaymentApi
//{
//    public partial class Payment
//    {
//        [JsonProperty("hash")]
//        public string Hash { get; set; }

//        [JsonProperty("pin")]
//        public string Pin { get; set; }

//        [JsonProperty("country")]
//        public string Country { get; set; }

//        [JsonProperty("merchant_payment_code")]
//        public string MerchantPaymentCode { get; set; }

//        [JsonProperty("order_number")]
//        public string OrderNumber { get; set; }

//        [JsonProperty("status")]
//        public string Status { get; set; }

//        [JsonProperty("status_date")]
//        public string StatusDate { get; set; }

//        [JsonProperty("open_date")]
//        public string OpenDate { get; set; }

//        [JsonProperty("confirm_date")]
//        public string ConfirmDate { get; set; }

//        [JsonProperty("transfer_date")]
//        public string TransferDate { get; set; }

//        [JsonProperty("amount_br")]
//        public float AmountBr { get; set; }

//        [JsonProperty("amount_ext")]
//        public float AmountExt { get; set; }

//        [JsonProperty("amount_iof")]
//        public float AmountIof { get; set; }

//        [JsonProperty("currency_rate")]
//        public float CurrencyRate { get; set; }

//        [JsonProperty("currency_ext")]
//        public string CurrencyExt { get; set; }

//        [JsonProperty("due_date")]
//        public string DueDate { get; set; }

//        [JsonProperty("instalments")]
//        public int Instalments { get; set; }

//        [JsonProperty("payment_type_code")]
//        public string PaymentTypeCode { get; set; }

//        [JsonProperty("boleto_url")]
//        public Uri BoletoUrl { get; set; }

//        [JsonProperty("boleto_barcode")]
//        public string BoletoBarcode { get; set; }

//        [JsonProperty("boleto_barcode_raw")]
//        public string BoletoBarcodeRaw { get; set; }

//        [JsonProperty("pre_approved")]
//        public bool? PreApproved { get; set; }

//        [JsonProperty("capture_available")]
//        public bool? CaptureAvailable { get; set; }

//        [JsonProperty("transaction_status")]
//        public TransactionStatus TransactionStatus { get; set; }

//        public PaymentStatusEnum PaymentStatus 
//        {
//            get
//            {
//                try
//                {
//                    switch (Status)
//                    {
//                        case "CO": return PaymentStatusEnum.Confirmed;
//                        case "OP": return PaymentStatusEnum.Open;
//                        case "PE": return PaymentStatusEnum.Pending;
//                        case "CA": return PaymentStatusEnum.Cancelled;
//                        default: return PaymentStatusEnum.Unknown;
//                    }

//                }

//                catch(Exception e)
//                {
//                    return PaymentStatusEnum.Unknown;
//                }
//            }
//        }

//        /// <summary>
//        /// <para><b>(Open) OP:</b> the customer has not yet filled the payment details on the EBANX Checkout. It can change either to CA (time out) or PE.</para>
//        /// <para><b>(Pending) PE:</b> the payment is pending confirmation. It can change either to CA or CO.</para>
//        /// <para><b>(Confirmed) CO:</b> the payment is confirmed (paid).</para>
//        /// <para><b>(Cancelled) CA:</b> the payment is cancelled.</para>
//        /// </summary>
//        public enum PaymentStatusEnum
//        {
//            Unknown,
//            Open,
//            Pending,
//            Confirmed,
//            Cancelled
//        }

//        public bool IsPaid 
//        {
//            get
//            {
//                return PaymentStatus == PaymentStatusEnum.Confirmed;
//            }
//        }
//    }

//    public class TransactionStatus
//    {
//        [JsonProperty("acquirer")]
//        public string Acquirer { get; set; }

//        [JsonProperty("code")]
//        public string Code { get; set; }

//        [JsonProperty("description")]
//        public string Description { get; set; }

//        [JsonProperty("authcode")]
//        public string Authcode { get; set; }

//        public bool Sucess
//        {
//            get
//            {
//                return Code.ToUpper() == "OK";
//            }
//        }
//    }
//}
