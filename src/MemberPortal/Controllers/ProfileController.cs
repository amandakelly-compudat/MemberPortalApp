using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MemberPortal.Controllers
{
    [Route("profile")]
    public class ProfileController : Controller
    {
        [Route("")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("WorkHistory")]
        public IActionResult WorkHistory()
        {
            return View();
        }

        [Route("PensionDetail")]
        public IActionResult PensionDetail()
        {
            return View();
        }

        [Route("PensionCreditHistory")]
        public IActionResult PensionCreditHistory()
        {
            return View();
        }

        [Route("PensionerDetail")]
        public IActionResult PensionerDetail()
        {
            return View();
        }

        [Route("AnnuityDetail")]
        public IActionResult AnnuityDetail()
        {
            return View();
        }

        [Route("HWDetail")]
        public IActionResult HWDetail()
        {
            return View();
        }

        [Route("Dependents")]
        public IActionResult Dependents()
        {
            return View();
        }
    }
}
