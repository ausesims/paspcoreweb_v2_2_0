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
            ViewData["Projects Title"] = "PROJECT LISTING";

            ViewData["Projects Message"] = "This page list projects, which are current, on-going " +
                "or have been completed. All public projects are accessable via GitHub and private" +
                " projects are accessable via Azure DevOps (formerly Team Foundation Services)";

            ViewData["Projects Instructions"] = "Click on a button to view the project information.";            

            return View();
        }

        public ActionResult Portfolio()
        {
            ViewData["Portfolio Title"] = "PORTFOLIO";

            ViewData["Portfolio Message"] = "To be implimented on 09/21/2019";

            return View();
        }

        public ActionResult Sites()
        {
            ViewBag.Message = "EXTERNAL TECHNOLOGY SITES";

            return View();
        }

        public ActionResult Blog()
        {
            ViewData["Blog Title"] = "BLOG";
            ViewData["Blog Message"] = "To be implmented on 09/20/2019.";

            return View();
        }

        public ActionResult Art()
        {
            ViewData["Art Title"] = "ART";
            ViewData["Art Message"] = "To be implmented on 09/19/2019";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Contact Title"] = "CONTACT INFORMATION";

            ViewData["Contact Message"] = "You can use one of several various methods " +
                "listed below to contact me. For online chat hours please view" +
                " the schedule listed at the bottom of the page.";

            return View();
        }

        public ActionResult ChangeLog()
        {
            ViewData["Change Log Title"] = "CHANGE LOG";

            ViewData["Change Log Message"] = "The site Change Log which warrants, changes, additions, or " +
                "corrections to the stie and it's content. Site changes are preformed on a monthly basis" +
                " with the exception of emgerency changes. An alert pop-up will be present on this page when " +
                "a emgerency change is in progress. All public project changes are posted to GitHub and all" +
                " private project changes are posted to Azure DevOps";

            ViewData["Change Log Instructions"] = "Click on a button below to list the assoicated change";

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
