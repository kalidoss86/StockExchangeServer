using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange.Model
{
    public class OrderBook
    {
        public string Symbol { get; set; }

        public string Exchange { get; set; }

        public OrderList Ask { get; set; }

        public OrderList Bid { get; set; }

        public List<Trade> TradeList { get; set; }

        private object _lock = new object();

        public OrderBook(string symbol, string exchange)
        {
            Symbol = symbol;
            Exchange = exchange;
            Bid = new OrderList(Symbol, MarketSide.Bid);
            Ask = new OrderList(Symbol, MarketSide.Ask);
            TradeList = new List<Trade>();
        }

        public void MatchTrade()
        {
            var AskOrder = Ask.GetTopMost();
            var BidOrder = Bid.GetTopMost();

            var order = AskOrder.TimeStamp < BidOrder.TimeStamp ? AskOrder : BidOrder;

            if (order.Side == MarketSide.Ask) //Sell
            {
                var bids = Bid.Where(s => s.Price >= order.Price);
                //Process the order
                var quantity = order.Volume;
                Trade trade = null;
                foreach (var item in bids)
                {
                    if (item.Volume >= quantity)
                    {
                        if (trade == null)
                        {
                            trade = new Trade(DateTime.Now, Symbol, Exchange, item.Price, quantity);
                        }
                    }
                    else
                    {
                        if (trade == null)
                        {
                            trade = new Trade(DateTime.Now, Symbol, Exchange, item.Price, item.Volume);
                        }
                    }
                    item.Volume = item.Volume - trade.Volume;
                    quantity = quantity - trade.Volume;
                    if (quantity ==0)
                    {
                        break;
                    }
                }
                TradeList.Add(trade);


            }
        }

        public void SubmitOrder(Event eventItem)
        {
            OrderList list = eventItem.Flags == MarketSide.Bid ? Bid : Ask;
            lock (_lock)
            {
                list.SubmitOrder(eventItem);
            }
        }
    }
}
