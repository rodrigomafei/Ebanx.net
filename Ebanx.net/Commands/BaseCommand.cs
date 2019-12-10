using System;
using System.Collections.Generic;
using System.Text;
using static Ebanx.net.Helpers.EbanxUrlHelper;

namespace Ebanx.net.Commands
{
    public class BaseCommand
    {
        public APIEnvironment Environment { get; set; }
    }
}
