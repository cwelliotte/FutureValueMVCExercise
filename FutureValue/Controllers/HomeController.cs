using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0m;
            return View();
        }
        [HttpPost]
        public IActionResult Index(FutureValue.Models.FutureValueModel model)
        {
            if (ModelState.IsValid)
                ViewBag.FV = model.CalculateFutureValue();
            else
                ViewBag.FV = 0;
            return View(model);
        }
    }
}
