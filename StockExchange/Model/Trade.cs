using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange.Model
{
    public class Trade
    {
        public DateTime TimeStamp { get; set; }

        public string Symbol { get; set; }

        public string Exchange { get; set; }

        public double Price { get; set; }

        public long Volume { get; set; }

        public Trade(DateTime timeStamp, string symbol, string exchange, double price, long volume )
        {
            TimeStamp = timeStamp;
            Symbol = symbol;
            Exchange = exchange;
            Price = price;
            Volume = volume;
        }

        public new string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(TimeStamp.ToUniversalTime());
            output.Append("\t");
            output.Append(Symbol);
            output.Append("\t");
            output.Append(Exchange);
            output.Append("\t");
            output.Append(Price.ToString());
            output.Append("\t");
            output.Append(Volume);
            return output.ToString();
        }
    }
}
