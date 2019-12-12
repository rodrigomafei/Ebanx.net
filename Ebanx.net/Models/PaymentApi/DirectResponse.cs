namespace Ebanx.net.Models.PaymentApi
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class DirectResponse
    {
        [JsonProperty("payment")]
        public Payment Payment { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_code")]
        public string StatusCode { get; set; }

        [JsonProperty("status_message")]
        public string StatusMessage { get; set; }
    }

    public partial class Payment
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("pin")]
        public string Pin { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("merchant_payment_code")]
        public string MerchantPaymentCode { get; set; }

        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_date")]
        public string StatusDate { get; set; }

        [JsonProperty("open_date")]
        public string OpenDate { get; set; }

        [JsonProperty("confirm_date")]
        public string ConfirmDate { get; set; }

        [JsonProperty("transfer_date")]
        public string TransferDate { get; set; }

        [JsonProperty("amount_br")]
        public float AmountBr { get; set; }

        [JsonProperty("amount_ext")]
        public float AmountExt { get; set; }

        [JsonProperty("amount_iof")]
        public float AmountIof { get; set; }

        [JsonProperty("currency_rate")]
        public float CurrencyRate { get; set; }

        [JsonProperty("currency_ext")]
        public string CurrencyExt { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("instalments")]
        public int Instalments { get; set; }

        [JsonProperty("payment_type_code")]
        public string PaymentTypeCode { get; set; }

        [JsonProperty("boleto_url")]
        public Uri BoletoUrl { get; set; }

        [JsonProperty("boleto_barcode")]
        public string BoletoBarcode { get; set; }

        [JsonProperty("boleto_barcode_raw")]
        public string BoletoBarcodeRaw { get; set; }

        [JsonProperty("pre_approved")]
        public bool? PreApproved { get; set; }

        [JsonProperty("capture_available")]
        public bool? CaptureAvailable { get; set; }
    }
}
