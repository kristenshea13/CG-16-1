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

        //Post method to correspond to form data from index.cshtml
        [HttpPost]
        public IActionResult Index(string language, string firstName)
        {
            //inputs are language and user-entered first name
            ViewBag.Firstname = firstName;
            //create greeting using method below which returns translated greeting
            //combined with the user's first name
            ViewBag.greeting = CreateMessage(language, firstName);
            return View();
        }

        
        //method to return translated greeting with inputs of language and first name
        public static string CreateMessage(string language, string firstName)
        {
            //just used *if* statements, it works and code looks more uniform
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

            //default return, will not hit due to form having drop-down menu 
            //and a default of English
            return "Invalid input";
            

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}