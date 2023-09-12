using Microsoft.AspNetCore.Mvc;
using Mod4Demo.Models;

namespace Mod4Demo.Controllers
{
    public class OtherController : Controller
    {
        public IActionResult Index()
        {
            Person p = new Person();
            p.Id = 1;
            p.Name = "XYZ";
            ViewBag.ServerTime = DateTime.Now;
            ViewData["data"] = "sample text";
            ViewData["result"] = "500";
            return View(p);
        }
    }
}
