using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestAspNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string dani = "Daniel";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Message = "Daniel Gelan";
            ViewBag.Message = "Hailemariam Kebede Mamo";
            viewbag.message = "Ebsa Erreso";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}