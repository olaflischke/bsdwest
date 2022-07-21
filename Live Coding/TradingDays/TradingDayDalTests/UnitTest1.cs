using TradingDayDal;

namespace TradingDayDalTests
{
    public class Tests
    {
        string url;

        [SetUp]
        public void Setup()
        {
            url = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist.xml";
        }

        [Test]
        public void IsArchiveInitializing()
        {
            Archive archive=new Archive(url);

            Console.WriteLine($"{archive.TradingDays?.FirstOrDefault()?.Date:dd.MM.yyyy}: USD - {archive.TradingDays?.FirstOrDefault()?.ExchangeRates?.FirstOrDefault().EuroRate}");

            Assert.AreEqual(64, archive.TradingDays?.Count);
        }
    }
}