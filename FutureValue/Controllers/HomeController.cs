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
            Debug.WriteLine(model.Years.ToString());
            Debug.WriteLine(model.YearlyInterestRate.ToString());
            Debug.WriteLine(model.MonthlyInvestment.ToString());
            ViewBag.FV = model.CalculateFutureValue();
            Debug.WriteLine(model.CalculateFutureValue());
            return View(model);
        }
    }
}
