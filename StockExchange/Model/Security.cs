using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange.Model
{
    public class Security
    {
        public string Symbol { get; set; }

        public List<Trade> Trades { get; set; }

        public Dictionary<string, OrderBook> OrderBook { get; set; }


        public Security(string symbol)
        {
            Symbol = symbol;
            OrderBook = new Dictionary<string, OrderBook>();
            Trades = new List<Trade>();
        }

        public void EventRecieved(Event eventItem)
        {
            if (!OrderBook.TryGetValue(eventItem.Exchange, out OrderBook orderBook))
            {
                orderBook = new Model.OrderBook(eventItem.Code, eventItem.Exchange);
                OrderBook.Add(eventItem.Exchange, orderBook);
            }
            orderBook.SubmitOrder(eventItem);
        }
    }
}
