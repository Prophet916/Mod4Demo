using Microsoft.AspNetCore.Mvc;
using Mod4Demo.Models;
using System.Diagnostics;

namespace Mod4Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // 1. IactionResult
        public IActionResult Index()
        {

            return View(); // default search Index view in Home folder
        }

        // 2. ViewResult
        public ViewResult Method1()
        {
            string name = RouteData.Values["id"].ToString();
            ViewBag.Name = name;
            return View("Index");
        }

        // 3. Content result
        public ContentResult Method2()
        {
            return Content("sample content from method2"); // returns string to the browser, no html
        }

        // 4. RedirectToAction
        public RedirectToActionResult Method3()
        {
            return RedirectToAction("Privacy");
        }

        // 5. StatusCodeResult

        public StatusCodeResult Method5()
        {
            return new StatusCodeResult(500);
        }

        // 6. ReDirectResult
        public RedirectResult Google()
        {
            return Redirect("http://www.google.com");
        }

        //7 ReDirectToRoute
        public RedirectToRouteResult Method6()
        {
            return RedirectToRoute(new {Action = "Index", Controller = "Other"});
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