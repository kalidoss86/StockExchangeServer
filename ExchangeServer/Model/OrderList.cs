using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeServer.Model
{
    public class OrderList : List<Order>
    {
        public string Symbol { get; set; }

        public MarketSide Side { get; set; }

        private int TotalOrderProcessed;

        public OrderList(string symbol, MarketSide side)
        {
            Symbol = symbol;
            Side = side;
            TotalOrderProcessed = 0;
        }

        public Order GetNext(OrderType orderType)
        {
            Order order = null;
            //if (Count > TotalOrderProcessed)
            {
                order = this.Where(o => o.Status != OrderStatus.Completed && o.Type == orderType).OrderBy(x => x.TimeStamp).FirstOrDefault();
                TotalOrderProcessed++;
            }
            return order;
        }

        public void SubmitOrder(Order order)
        {
            Add(order);
        }

        public void RemoveOrder(Order order)
        {
            Remove(order);
        }

        public OrderList Merge(OrderList otherList)
        {
            OrderList temp = new OrderList(Symbol, Side);
            try
            {
                var list = this.Concat(otherList).ToList();

                foreach (var item in list)
                {
                    temp.Add(item);
                }

            }
            catch (Exception e)
            {

            }

            return temp;
        }
    }
}

