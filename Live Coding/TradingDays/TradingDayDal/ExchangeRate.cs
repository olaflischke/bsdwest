namespace TradingDayDal
{
    public class ExchangeRate
    {
        public string Symbol { get; set; }
        public double EuroRate { get; set; }

        public string Location { get; set; }

        public void Deconstruct(out string symbol, out double rate)
        {
            symbol=this.Symbol;
            rate = this.EuroRate;
        }

        public void Deconstruct(out string symbol, out double rate, out string location)
        {
            symbol = this.Symbol;
            rate = this.EuroRate;
            location = this.Location;
        }

    }

    public record class ExchangeRateRecord
    {
        public string Symbol { get; set; }
        public double EuroRate { get; set; }

        public void Deconstruct(out string symbol, out double rate)
        {
            symbol = this.Symbol;
            rate = this.EuroRate;
        }

    }

    public record class ExchangeRateRecordClassPositional(string Symbol, double EuroValue);


    public record struct ExchangeRateRecordStruct
    {
        public string Symbol { get; set; }
        public double EuroRate { get; set; }
    }

    public record struct ExchangeRateRecordStructPositional(string Symbol, double EuroValue);


}