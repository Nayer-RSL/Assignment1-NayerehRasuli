using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication6.Controllers
{
    public class NumberMachineController : ApiController
    {

        public int Get(int id)
        {
            int product = (id * id) + id - (id / id);
            return product;
        }
    }
}
