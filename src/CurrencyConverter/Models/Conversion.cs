using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Models
{
    public class Conversion
    {
        public float Amount;
        public float FirstRate;
        public float SecondRate;

        public Conversion(int amount, string firstCurrency, string secondCurrency)
        {
            this.Amount = amount;
            this.FirstRate = Rates.FindRateFor(firstCurrency);
            this.SecondRate = Rates.FindRateFor(secondCurrency);
        }

        public void Convert()
        {
            this.Amount = this.Amount / this.FirstRate * this.SecondRate;
        }
    }
}
