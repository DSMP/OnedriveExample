using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GraphTutorial.Controllers
{
    public class ExplorerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
