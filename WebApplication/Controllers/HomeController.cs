using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var str = ClassLibraryV2.CacheHelper.getTickekInfoFormCacheString("5EA7A329F656E834418D99A8F576FF9A5DC7ED144826A7EC7BFDC3B86496E469867E08614920D1E1C2F3009C601A5228F1CF7DE1F5D451FFA4E5659E5E2B0328D6FE544C2DFC78464460893CAA118F22EBA52527D48B854653B7706711371C1A2CBE70E0EFE6C7F3CE55206A93BFBB897A8469017112E10A517B7F0BA100EACDCAE4D150382044B548126FB1E20DF1BC22778566BD471CFBC21DBC9ED359E4468DA1B80E417FE7B49876A171F796D833A02559D8");
            return Content(str);
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
