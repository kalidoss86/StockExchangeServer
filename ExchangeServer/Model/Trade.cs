using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeServer.Model
{
    public class Trade
    {

        public string Symbol { get; set; }

        public string Exchange { get; set; }

        public DateTime TimeStamp { get; set; }

        public double TradedPrice { get; set; }

        public long Quantity { get; set; }

        public Trade(string symbol, string exchange)
        {
            Symbol = symbol;
            Exchange = exchange;
            TradedPrice = 0.0;
            Quantity = 0;
            TimeStamp = DateTime.Now;
        }

        public Trade(string symbol, string exchange, double price, long quatity)
        {
            Symbol = symbol;
            Exchange = exchange;
            TradedPrice = price;
            Quantity = quatity;
            TimeStamp = DateTime.Now;
        }

        public void UpdateTrade(double price, long quantity)
        {
            var totalQuantity = Quantity + quantity;
            var totalAmount = TradedPrice * Quantity + price * quantity;
            var averagePrice = totalAmount / totalQuantity;
            TradedPrice = averagePrice;
            Quantity += quantity;
        }
    }
}
