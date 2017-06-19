using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MemberPortal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [Route ("LoggedOut")]
        public IActionResult LoggedOut()
        {
            ViewData["Message"] = "Thank you for choosing us.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
