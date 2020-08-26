using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MobileShoppingProject.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        testEntities _db = new testEntities();

        public ActionResult Index()
        {
            var data = _db.MobilePhoneDatas.ToList();
            return View();
        }
    }
}
