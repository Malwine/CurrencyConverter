using System;
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
            var model = new CurrencyConverter.Models.Conversion(0, 1, 1);
            return View("Index", model);
        }

        public IActionResult Create(string Amount, string originalCurrency, string targetCurrency)
        {
            var amount = Convert.ToInt32(Amount);
            var originalCur = Convert.ToInt32(originalCurrency);
            var targetCur = Convert.ToInt32(targetCurrency);

            var model = new CurrencyConverter.Models.Conversion(amount, originalCur, targetCur);
            model.Convert(); // exchange numbers for input from dropdowns
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
