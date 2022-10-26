using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPortalLanguages.Controllers
{
    public class LanguagesController : Controller
    {
        public IActionResult Teor()
        {
            return View();
        }

        public IActionResult Dictionary() { return View(); }

        public IActionResult Words() { return View(); }
    }
}
