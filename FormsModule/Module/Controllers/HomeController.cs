using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form_1a()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Form_1b()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}