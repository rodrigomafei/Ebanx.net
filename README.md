# Ebanx.net
Is a .net library from ([Ebanx Payments](https://developers.ebanxpagamentos.com/))

# Start
### Install your project
[![Nuget](https://img.shields.io/nuget/dt/Ebanx.net)](https://www.nuget.org/packages/Ebanx.net)
[![Nuget](https://img.shields.io/nuget/v/Ebanx.net)](https://www.nuget.org/packages/Ebanx.net)

```npm
PM > Install-Package Ebanx.net
```

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
## Support
| Operation     |Working| Api
| -------------|:--------:| :--------|
| Token |✔ | TokenOperationApi.GeneratedToken() |
| Direct  |✔ | DirectOperationApi.GeneratedDirect() |

## Additional
 - For to run tests in this project, set your keys in ([TestBase Class](https://github.com/rodrigomafei/Ebanx.net/blob/master/Test/Base/TestBase.cs))
