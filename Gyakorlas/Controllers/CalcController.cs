using Gyakorlas.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gyakorlas.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sum(CalcModel model)
        {
            int c = model.A + model.B;
            String output = c.ToString();

            return Content(output);
        }
    }
}
