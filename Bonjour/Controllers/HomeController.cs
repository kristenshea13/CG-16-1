﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bonjour.Models;

namespace Bonjour.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index(string firstName, string lastName)
        //{
        //    return View();
        //}


        public IActionResult Index(string firstName)
        {
            ViewBag.Firstname = firstName;
            //ViewBag.Lastname = lastName;
            return View();
        }

        //public IActionResult CreateMessage(string firstName)
        //{
        //    ViewBag.Firstname = firstName;

        //    return View();

        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
