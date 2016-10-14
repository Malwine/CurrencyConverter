using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace CurrencyConverter.Models
{
    public static class Rates
    {
        public static string Parsing()
        {
            string text = "";
            XmlDocument doc = new XmlDocument();
            doc.Load("https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml");
            foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("currency"))
            {
                text = node.InnerText;
            }
            return text;
        }

        public static Dictionary<string, int> AllRates() {
            return new Dictionary<string, int>() { { "EUR", 1 }, { "USD", 2}, {"JPY", 40} };
        }

        public static int FindRateFor(string currency)
        {
            int value = 0;
            AllRates().TryGetValue(currency, out value);
            return value;
        }

        public static string[] AllCurrencies()
        {
            return AllRates().Keys.ToArray();
        }

    }
}
