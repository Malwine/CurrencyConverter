﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace CurrencyConverter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // TODO: find better solution in order to not get a null pointer exception:
            var model = new Models.Conversion(0, "EUR", "EUR");
            return View("Index", model);
        }

        public IActionResult Create(string Amount, string originalCurrency, string targetCurrency)
        {
            var amount = Convert.ToInt32(Amount);
            var originalCur = originalCurrency;
            var targetCur = targetCurrency;

            var model = new Models.Conversion(amount, originalCur, targetCur);
            model.Convert();
            return View("Index", model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
