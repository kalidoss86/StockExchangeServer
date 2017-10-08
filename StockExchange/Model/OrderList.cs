using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange.Model
{
    public class OrderList : List<Order>
    {
        public string Symbol { get; set; }

        public MarketSide Side { get; set; }

        public OrderList(string symbol, MarketSide side )
        {
            Symbol = symbol;
            Side = side;
        }

        public Order GetTopMost()
        {
            return this.OrderBy(a => a.TimeStamp).First();
        }


        public void SubmitOrder(Event eventItem)
        {
            Order ord = eventItem.ToOrder();
            Add(ord);
        }
    }
}
