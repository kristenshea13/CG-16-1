﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bonjour.Controllers
{
    public class DropdownController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}