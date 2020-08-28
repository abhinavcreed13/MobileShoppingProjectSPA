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
        testEntities _db = new testEntities();
        public string Get()
        {
            return "Welcome to mobile shop!";
        }

        public List<MobilePhoneData> GetPhoneData()
        {
            return _db.MobilePhoneDatas.ToList();
        }
    }
}
