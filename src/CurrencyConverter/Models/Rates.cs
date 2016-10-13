using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Models
{
    public class Rates
    {

        public Dictionary<string, int> getRates() {
           return new Dictionary<string, int>() { { "EUR", 1 }, { "USD", 2}, {"JPY", 40} };
        }
    }
}
