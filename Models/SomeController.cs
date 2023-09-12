using Microsoft.AspNetCore.Mvc;

namespace Mod4Demo.Models
{
    public class SomeController : Controller
    {
        [Route("/BestRestaurants")]
        public IActionResult GetRestaurants()
        {
            return Content("this is list of best restaurants...");
        }

        [Route("/Print/{fname}/{lname}")]
        public IActionResult PrintName(string fname, string lname)
        {
            return Content("Hello: " + fname + " " + lname);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
