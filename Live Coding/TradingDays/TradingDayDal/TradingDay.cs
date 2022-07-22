using System.Globalization;
using System.Xml.Linq;

namespace TradingDayDal
{
    public class TradingDay
    {
        public TradingDay(XElement tradingDayNode)
        {
            this.Date = DateOnly.Parse(tradingDayNode.Attribute("time").Value);

            this.ExchangeRateRecords = tradingDayNode.Elements().Select(el => new ExchangeRateRecord()
                                                                        {
                                                                            EuroRate = Convert.ToDouble(el.Attribute("rate").Value, CultureInfo.InvariantCulture),
                                                                            Symbol = el.Attribute("currency").Value
                                                                        })
                                                            .ToList();


            //ExchangeRateRecord rec1 = new ExchangeRateRecord() { EuroRate = 2, Symbol = "ABC" };
            //ExchangeRateRecord rec2 = new ExchangeRateRecord() { EuroRate = 0.5, Symbol = "DEF" };

            // Record-Vergleich
            //if (rec1 != rec2)
            //{
                
            //}

            //ExchangeRate cls1 = new ExchangeRate() { EuroRate = 2, Symbol = "ABC" };
            //ExchangeRate cls2 = new ExchangeRate() { EuroRate = 0.5, Symbol = "DEF" };

            // Objektvergleich
            //if (cls1.Equals(cls2))
            //{

            //}

        }

        public TradingDay(XElement tradingDayNode, bool useStructs)
        {
            this.Date = DateOnly.Parse(tradingDayNode.Attribute("time").Value);

            this.ExchangeRates = tradingDayNode.Elements().Select(el => new ExchangeRateRecordStruct()
                                                                        {
                                                                            EuroRate = Convert.ToDouble(el.Attribute("rate").Value, CultureInfo.InvariantCulture),
                                                                            Symbol = el.Attribute("currency").Value
                                                                        })
                                                            .ToList();
        }

        public DateOnly Date { get; set; }
        public List<ExchangeRateRecordStruct> ExchangeRates { get; set; }
        public List<ExchangeRateRecord> ExchangeRateRecords { get; set; }

    }
}