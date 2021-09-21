using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnIslam.com.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult History()
        {
            return View();
        }
        public ActionResult Quran()
        {
            return View();
        }
    }
}