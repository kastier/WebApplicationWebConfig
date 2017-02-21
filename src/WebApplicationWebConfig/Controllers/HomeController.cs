using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace WebApplicationWebConfig.Controllers
{
    public class HomeController : Controller
    {

          public IActionResult Index()
        {

            var str = "hi";//ClassLibrary.WebConfig.getStr();//getAppSettings("option");
            //ViewBag.hiword = Config.WebConfig.getAppSettings("name");
            
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

        public IActionResult Error()
        {
            return View();
        }
    }
}
