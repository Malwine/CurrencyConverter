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
            var model = new CurrencyConverter.Models.Amount(0);
            return View("Index", model);
        }

        public IActionResult Create(string Amount)
        {
            var model = new CurrencyConverter.Models.Amount(Convert.ToInt32(Amount));
            model.Convert(2, 5); // exchange numbers for input from dropdowns
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
