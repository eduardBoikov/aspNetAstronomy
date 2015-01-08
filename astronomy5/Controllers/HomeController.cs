using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using astronomy5.Models;
namespace astronomy5.Controllers
{
    public class HomeController : Controller
    {

        AstronomyEntities astroDB = new AstronomyEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ChooseData()
        {
            return View();
        }

        public ActionResult Missions()
        {
            var missijas = astroDB.Misijas.ToList();

            return View(missijas);
        }

        public ActionResult Planets()
        {
            var planetas = astroDB.Planetas.ToList();

            return View(planetas);
        }

        public ActionResult Aircrafts()
        {
            var aparati = astroDB.Aparati.ToList();

            return View(aparati);
        }

        public ActionResult Satellites()
        {
            var pavadoni = astroDB.Pavadoni.ToList();
            return View(pavadoni);
        }
    }
}