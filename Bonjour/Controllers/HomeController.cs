using Bonjour.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bonjour.Controllers
{
    public class HomeController : Controller
    {
        
        
        public IActionResult Index(string firstName)
        {
            
            ViewBag.Firstname = firstName;

            return View();
        }

        //[HttpPost]
        //[Route("/greet")]

        //public static string CreateMessage(string value, string firstName)
        //{
            

        //}
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}