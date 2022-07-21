namespace TradingDayDal
{
    public class ExchangeRate
    {
        public string Symbol { get; set; }
        public double EuroRate { get; set; }
    }

    public record class ExchangeRateRecord
    {
        public string Symbol { get; set; }
        public double EuroRate { get; set; }
    }

    public record class ExchangeRateRecordClassPositional(string Symbol, double EuroValue);


    public record struct ExchangeRateRecordStruct
    {
        public string Symbol { get; set; }
        public double EuroRate { get; set; }
    }

    public record struct ExchangeRateRecordStructPositional(string Symbol, double EuroValue);


}