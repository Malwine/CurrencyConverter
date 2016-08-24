using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Models
{
    public class Amount
    {
        public int BaseAmount;

        public Amount(int InputAmount) 
        {
            BaseAmount = InputAmount;
        }
    }
}
