using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspcoreweb_blog_v2_2_0.Models;

namespace aspcoreweb_blog_v2_2_0.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "My projects list";

            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Message = "My Portfolo";

            return View();
        }

        public ActionResult Sites()
        {
            ViewBag.Message = "My website listings page.";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact information for Ause Sims";

            return View();
        }

        public ActionResult ChangeLog()
        {
            ViewBag.Message = "Site change-log actions which warrant, changes, additions, or corrections to the stie.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
