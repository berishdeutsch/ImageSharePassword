using ImageSharePassword.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ImageSharePassword.Web.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            test
            return View();
        }
        [HttpPost]
        public IActionResult Upload()
        {
            return View();
        }
        public IActionResult ViewImage()
        {
            return View();
        }
    }
}
