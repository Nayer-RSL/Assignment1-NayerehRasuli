using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication6.Controllers
{
    public class HostingCostController : ApiController
    {

        public string Get(int id)
        {

            double HST = 0.13;
            int FN = (id / 14) + 1;
            double PriceFN = 5.5;
            double Net = FN * PriceFN;
            double Tax = HST * Net;
            double Final = Tax + Net;
            string Sen1 = FN + " fortnights at $5.50/FN = $" + Net + " CAD";
            string Sen2 = "\n HST 13% = $" + Tax + " CAD";
            string Sen3 = "\n Total = $" + Final + " CAD";
            return Sen1 + Sen2 + Sen3;
        }
    }
}
