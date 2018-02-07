using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace AllTest.Controllers
{
    public class MainController : Controller
    {
        public IActionResult AngularJSTest()
        {
            return View();
        }

        public IActionResult AjaxTest(string a)
        {
            return Content("<button>" + a + "</button>");
        }
    }
}
