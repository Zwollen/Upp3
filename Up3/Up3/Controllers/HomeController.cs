using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Up3.Models;

namespace Up3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult News()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Recommendations()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Series()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ListShows()
        {
            ShowsModels allShows = new ShowsModels();
            allShows.GetShows;
            

            return View();
        }
    }
}