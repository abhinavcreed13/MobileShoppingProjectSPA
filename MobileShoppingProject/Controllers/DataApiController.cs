using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MobileShoppingProject.Controllers
{
    public class DataApiController : ApiController
    {
        public string Get()
        {
            return "DataAPI is ready!";
        }
    }
}
