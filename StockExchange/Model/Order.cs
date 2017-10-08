using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange.Model
{
    public class Order
    {
        public MarketSide Side { get; set; }

        public double Price { get; set; }

        public DateTime TimeStamp { get; set; }

        public long Volume { get; set; }

        public Order(MarketSide side, double price, long volume, DateTime timeStamp)
        {
            Side = side;
            Price = price;
            Volume = volume;
            TimeStamp = timeStamp;
        }

        public Order Clone()
        {
            return new Order(Side, Price, Volume, TimeStamp);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(Price.ToString());
            output.Append("\t");
            output.Append(TimeStamp.ToUniversalTime());
            output.Append("\t");
            output.Append(Volume);
            output.Append("\t");

            return output.ToString();
        }
    }
}
