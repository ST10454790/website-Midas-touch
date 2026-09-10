using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using XLBondsKZN_Website.Models;

namespace XLBondsKZN_Website.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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

        public IActionResult TipsAndAdvice()
        {
            return View("~/Views/Advice&Tips/Tips and Advice.cshtml");
        }
        public IActionResult ClientTestimonials()
        {
            return View("~/Views/testimonials/client testimonials.cshtml");
        }
    }
}
