using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeServer.Model
{
    public class Position
    {
        public string Symbol { get; set; }

        public long Quantity { get; set; }

        public double AveragePrice { get; set; }

        public double LastTradedPrice { get; set; }

        public Position(string symbol, long quantity, double averagePrice )
        {
            Symbol = symbol;
            Quantity = quantity;
            AveragePrice = averagePrice;
        }
    }
}
