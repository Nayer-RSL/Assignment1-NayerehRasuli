using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication6.Controllers
{
    public class SquareController : ApiController
    {

        public int Get(int id)
        {
            int product = id * id;
            return product;
        }
    }
}
