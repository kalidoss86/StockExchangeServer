using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeServer.Model
{
    public class Security
    {
        public string Symbol { get; set; }

        public double LastTradedPrice { get; set; }

        public long MarketCapital { get; set; }

        public long TotalShares { get; private set; }

        public long AllowedSharesForTrading
        {
            get
            {
                return TotalShares / 2;
            }
        }

        public Dictionary<string, OrderBook> OrderBook { get; set; }

        public delegate void TradeCompletedHander(object sender, TradeCompletedEventArgs e);

        public event TradeCompletedHander TradeCompleted;

        public Security(string symbol, double lasttradedprice, long marketcap)
        {
            Symbol = symbol;
            LastTradedPrice = lasttradedprice;
            MarketCapital = marketcap;
            TotalShares = (long)(MarketCapital / LastTradedPrice);
            OrderBook = new Dictionary<string, OrderBook>();
        }

        public void SubmitOrder(Order order)
        {
            if (!OrderBook.TryGetValue(order.Symbol, out OrderBook orderBook))
            {
                orderBook = new OrderBook(order.Symbol, order.Exchange);
                orderBook.TradeCompleted += OrderBook_TradeCompleted;
                OrderBook.Add(order.Symbol, orderBook);
            }
            orderBook.SubmitOrder(order);
        }

        private void OrderBook_TradeCompleted(object sender, TradeCompletedEventArgs e)
        {
            LastTradedPrice = e.LastTradedPrice;

            TradeCompleted?.Invoke(this, e);

            System.Diagnostics.Debug.Print(LastTradedPrice.ToString());
        }

        public void ProcessOrder(OrderType orderType)
        {
            //Order needs to be processed First Come First Service
            foreach (var orders in OrderBook)
            {
                var order = orders.Value;

                order.ProcessOrder(orderType);

            }
        }
    }

}
