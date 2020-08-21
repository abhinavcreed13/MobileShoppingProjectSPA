using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MobileShoppingProject.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<object> vals = new List<object>();

            // 100 elements
            object[] vals2 = new object[100];


            return View();
        }
    }
}
