# Ebanx.net
Is a .net library from [Ebanx Payments](https://developers.ebanxpagamentos.com/)

# Start
### Install in your project
[![Nuget](https://img.shields.io/nuget/dt/Ebanx.net)](https://www.nuget.org/packages/Ebanx.net)
[![Nuget](https://img.shields.io/nuget/v/Ebanx.net)](https://www.nuget.org/packages/Ebanx.net)

```npm
PM > Install-Package Ebanx.net
```
## Support
| Operation     |Working| Api
| -------------|:--------:| :--------|
| [Token Operation](https://developers.ebanxpagamentos.com/api-reference/ebanx-payment-api/payment-reference/reference-token-operation/) |✔ | EbanxTokenOperationApi.Create() |
| [Direct Operation](https://developers.ebanxpagamentos.com/api-reference/ebanx-payment-api/payment-reference/reference-direct-operation/)  |✔ | EbanxDirectOperationApi.Create() |
| [Cancel Operation](https://developers.ebanxpagamentos.com/api-reference/ebanx-payment-api/payment-reference/reference-cancel-operation/)  |✔ | EbanxCancelOperationApi.Create() |
| [Capture Operation](https://developers.ebanxpagamentos.com/api-reference/ebanx-payment-api/payment-reference/reference-capture-operation/)  |✔ | EbanxCaptureOperationApi.Create() |
| [Query Operation](https://developers.ebanxpagamentos.com/api-reference/ebanx-payment-api/payment-reference/reference-query-operation/)  |✔ | EbanxQueryOperationApi.Create() |
| [RefundOrCancel Operation](https://developers.ebanxpagamentos.com/api-reference/ebanx-payment-api/payment-reference/reference-refund-or-cancel-operation/)  |✔ | EbanxRefundOrCancelOperationApi.Create() |
| [Refund Operation](https://developers.ebanxpagamentos.com/api-reference/ebanx-payment-api/payment-reference/reference-refund-operation/)  |✔ | EbanxRefundOperationApi.Create() |
| [Request Operation](https://developers.ebanxpagamentos.com/api-reference/ebanx-payment-api/payment-reference/reference-request-operation/)  |✔ | EbanxRequestOperationApi.Create() |
| [SetCvv Operation](https://developers.ebanxpagamentos.com/api-reference/ebanx-payment-api/payment-reference/setcvv-operation/)  | ✖ | EbanxSetCvvOperationApi.Create() |

### Configure
```csharp
new Config(new EbanxKeys
{
        PaymentKeys = new PaymentKey
        {
            StagIntegrationKey = "your key",
            StagPublicIntegrationKey = "your key",
            ProdIntegrationKey = "your key (not required to tests)",
            ProdPublicIntegrationKey = "your key (not required to run tests)"
        }
});
```

# How to use
        
### Create a Direct Operation sample ([all samples](https://github.com/rodrigomafei/Ebanx.net/tree/master/Test))
```csharp
var token = new TokenResponse();

using (var tokenApi = new EbanxTokenOperationApi())
{
        var request = new TokenRequest
        {
            Country = "BR",
            CreditCard = CreaditCardRequestExtention.GetACard(),
            PaymentTypeCode = "mastercard",
        };

        token = await tokenApi.Create(request);
}

var response = new DirectResponse();

using (var directApi = new EbanxDirectOperationApi())
{
        var request = new DirectRequest
        {
            Operation = "request",
            Mode = "full",
            Payment = new PaymentRequest
            {
                Name = "Customer Name",
                Email = "customer@mail.com",
                AmountTotal = 500,
                Zipcode = "000000",
                Address = "Rua X",
                StreetNumber = "5",
                City = "City",
                State = "SP",
                Country = "BR",
                PhoneNumber = "999999999",
                CreditCard = new CreditCardRequest
                {
                    Token = token.Token
                },
                CurrencyCode = "BRL",
                MerchantPaymentCode = Guid.NewGuid().ToString(),
                Document = "29479146002",
                Instalments = 12
            }
        };

        response = await directApi.Create(request);
}
```

## Additional
 - For to run tests in this project, set your keys in ([TestBase Class](https://github.com/rodrigomafei/Ebanx.net/blob/master/Test/Base/TestBase.cs))
 
 [![forthebadge](https://forthebadge.com/images/badges/built-with-love.svg)](#)
