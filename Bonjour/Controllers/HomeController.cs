using Bonjour.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bonjour.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(string language, string firstName)
        {
            ViewBag.Firstname = firstName;
            ViewBag.greeting = CreateMessage(language, firstName);
            return View();
        }

        //[HttpPost]
        //[Route("/greet")]

        public static string CreateMessage(string language, string firstName)
        {
            if (language == "English")
            {
                return $"Hello {firstName}!";
            }
            if (language == "Greek")
            {
                return $"Yasou {firstName}!";
            }
            if (language == "Hindi")
            {
                return $"Namaste {firstName}!";
            }
            if (language == "German")
            {
                return $"Guten tag {firstName}!";
            }
            if (language == "Spanish")
            {
                return $"¡Hola {firstName}!";
            }
            if (language == "French")
            {
                return $"Bonjour {firstName}!";
            }


            return "Invalid input";
            

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}