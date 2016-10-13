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

        public Conversion(int amount, int firstRate, int secondRate)
        {
            this.Amount = amount;
            this.FirstRate = firstRate;
            this.SecondRate = secondRate;
        }

        public void Convert()
        {
            this.Amount = this.Amount / this.FirstRate * this.SecondRate;
        }
    }
}
