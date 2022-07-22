using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingDayDal;

namespace TradingDayDalTests
{
    public class Deconstructing
    {
        void DeconstructingTuple()
        {
            var tuple1 = ("USD", 1.0199, new DateOnly(2022, 07, 22));

            var symbol1 = tuple1.Item1;
            var rate1 = tuple1.Item2;

            var tuple2 = (Symbol: "JPY", Rate: 141.46, Date: new DateOnly(2022, 07, 22));

            var symbol2 = tuple2.Symbol;

            // Deconstructing Tuple
            var (symbol3, rate3, date3) = tuple1;
            Console.WriteLine($"Am {date3} steht {symbol3} bei {rate3}");

            var (symbol4, rate4, date4) = GetDataFromTuple();
            Console.WriteLine($"Am {date4} steht {symbol4} bei {rate4}");
        }

        private (string, double, DateOnly) GetDataFromTuple()
        {
            string symbol = "BGN";
            double rate = 1.95583;
            DateOnly date = new DateOnly(2022, 07, 22);

            return (symbol, rate, date);
        }

        void DeconstructingRecord()
        {
            // PositionalRecord geht
            ExchangeRateRecordStructPositional exchangeRate = new ExchangeRateRecordStructPositional("ABC", 1.234);
            var (symbol, rate) = exchangeRate;

            // "Klassischer" Record geht nicht!
            //ExchangeRateRecordStruct structRate = new ExchangeRateRecordStruct() { Symbol = "CZK", EuroRate = 24.496 };
            //var (symbol2, rate2) = structRate;
        }

        void DeconstructingDictionary()
        {
            Dictionary<string, double> rates = new Dictionary<string, double>
            {
                {"USD", 1.1056 },
                {"JPY", 134.46 },
                {"PLN", 4.6423 },
                {"INR", 81.7115 }
            };

            foreach ((string key, double value) in rates)
            {
                Console.WriteLine($"{key}: {value}");
            }
        }

        void CheckString()
        {
            string plz = "44797";

            if (double.TryParse(plz, out double zahl))
            {
                
            }
        }

        void DeconstructingClass()
        {
            // Eigene Deconstrcut-Methode(n) in Klasse erforderlich!
            ExchangeRate rate = new ExchangeRate() { Symbol = "DKK", EuroRate = 7.4446, Location = "Börse Frankfurt" };

            var (symbol1, rate1) = rate;
            var (symbol2, rate2, location2) = rate;

            // Damit geht dann auch ein nicht-positional Record:
            ExchangeRateRecord rcd = new ExchangeRateRecord() { Symbol = "GBP", EuroRate = 0.85583 };
            var (symbol3, rate3)= rcd;

        }
    }
}
