using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingDayDal;

namespace TradingDayDalTests
{
    internal class NeuesLinq
    {
        void IndexerUndRanges()
        {
            string[] leute = { "Theo", "Klaus", "Werner", "Nicole", "Barbara", "Petra" };

            string klaus = leute[1];
            string barbara = leute[^2]; // "zweite(r) von hinten" - 1-basiert

            string[] maedels = leute[3..5]; // von/bis
            string[] kerle = leute[..2]; // bis 2
            string[] maedels2 = leute[3..]; // ab 3

            Range range = 0..2;
            string[] kerle2 = leute[range];

            int start = 2;
            int end = 5;
            Range range1 = new Range(start, end);
            string[] auserwaehlte = leute[range1];
         }

        void NeuesInLinq()
        {
            Archive archive = new Archive("https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist.xml");

            // Indexer/Range für LINQ
            var q1 = archive.TradingDays.Skip(1000).Take(100); // 100 TradingDays, Nr. 1001 - 1101
            var q2 = archive.TradingDays.Take(1000..1100); // 100 TradingDays, Nr. 1000 - 1100

            var q3 = archive.TradingDays.Take(^10..); // Die letzten 10 TradingDays.
            var q4 = archive.TradingDays.TakeLast(10);

            var q5 = archive.TradingDays.Chunk(100); // 100er-Blöcke von TradingDays

            // bekannt
            var q6 = archive.TradingDays.OrderBy(td => td.Date); // nach Datum aufsteigend sortiert
            var q7 = archive.TradingDays.OrderByDescending(td => td.Date); // absteigend

            // neu:
            var q8 = archive.TradingDays.MaxBy(td => td.ExchangeRates.Count); // Tradingday mit der größten Zahl von ExchangeRates (erster, falls mehrere gefunden)
            var q8a = archive.TradingDays.Max(td => td.ExchangeRates.Count); // Größte Zahl von ExchangeRates!
            // MaxBy, MinBy, DistinctBy, UnionBy, IntersectBy, ExceptBy
        }
    }
}
