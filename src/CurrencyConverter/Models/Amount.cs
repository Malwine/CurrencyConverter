using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Models
{
    public class Amount
    {
        public float BaseAmount;

        public Amount(int InputAmount) 
        {
            BaseAmount = InputAmount;
        }

        public void Convert(int firstRate, int secondRate)
        {
            this.BaseAmount = this.BaseAmount / firstRate * secondRate;
        }
    }
}
