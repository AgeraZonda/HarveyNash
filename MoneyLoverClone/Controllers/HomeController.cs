using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneyLoverClone.Controllers
{   
    public class HomeController : Controller
    {
        int currenttime = 1;
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Change(int id)
        {
            return View(id);
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
    }
}