using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace astronomy5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Par mums.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontakti.";

            return View();
        }
    }
}