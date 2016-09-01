using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Models
{
    public class ConversionRate
    {
        List<int> rates = new List<int>();

        public ConversionRate()
        {
            rates.Add(2);
            rates.Add(5);
        }
        
    }
}
