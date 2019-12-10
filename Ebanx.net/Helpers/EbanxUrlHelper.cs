using System;
using System.Collections.Generic;
using System.Text;
using static Ebanx.net.Constants;

namespace Ebanx.net.Helpers
{
    public static class EbanxUrlHelper
    {
        public static string GetApiUrl(APIEnvironment environment = APIEnvironment.Prod, APIName? name = null, string nameString = null)
        {
            var uri = string.Empty;

            switch (environment)
            {
                case APIEnvironment.Prod:
                    uri += APIUrl;
                    break;

                case APIEnvironment.Stag:
                    uri += APIUrlStag;
                    break;
            }

            if (name != null)
            {
                switch (name)
                {
                    case APIName.setCVV: return uri + "token/setCVV";

                    default: return uri + name.ToString();
                }

            }

            return uri += nameString;

        }

        public enum APIEnvironment
        {
            Prod,
            Stag
        }

        public enum APIName
        {
            direct,
            cancel,
            capture,
            print,
            query,
            refund,
            refundOrCancel,
            setCVV,
            token
        }
    }
}
