using System.Xml.Linq;

namespace TradingDayDal
{
    public class TradingDay
    {
        public TradingDay(XElement tradingDayNode)
        {
            this.Date = DateOnly.Parse(tradingDayNode.Attribute("time").Value);

            this.ExchangeRates = tradingDayNode.Elements().Select(el => new ExchangeRate()
                                                                        {
                                                                            EuroRate = Convert.ToDouble( el.Attribute("rate").Value),
                                                                            Symbol = el.Attribute("currency").Value
                                                                        })
                                                            .ToList();
        }

        public DateOnly Date { get; set; }
        public List<ExchangeRate> ExchangeRates { get; set; }

    }
}