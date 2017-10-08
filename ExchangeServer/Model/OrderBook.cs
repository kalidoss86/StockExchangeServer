using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeServer.Model
{
    public class OrderBook
    {
        public string Symbol { get; set; }

        public string Exchange { get; set; }

        public OrderList Asks { get; set; }

        public OrderList Bids { get; set; }

        public List<Trade> TradeList { get; set; }

        public long TotalOrders
        {
            get
            {
                return Asks.Count + Bids.Count;
            }
        }

        public long TotalLimitOrders
        {
            get
            {
                return Asks.Where(x => x.Type == OrderType.Limit).Count() + Bids.Where(x => x.Type == OrderType.Limit).Count();
            }
        }

        public long TotalMarketOrders
        {
            get
            {
                return Asks.Where(x => x.Type == OrderType.Market).Count() + Bids.Where(x => x.Type == OrderType.Market).Count();
            }
        }

        public long TotalBuyOrders
        {
            get
            {
                return Bids.Count;
            }
        }

        public long TotalSellOrders
        {
            get
            {
                return Asks.Count;
            }
        }

        public long CompletedBuyOrders
        {
            get
            {
                return Bids.Where(x => x.Status == OrderStatus.Completed).Count();
            }
        }

        public long CompletedSellOrder
        {
            get
            {
                return Asks.Where(x => x.Status == OrderStatus.Completed).Count();
            }
        }

        public long CompletedTrades
        {
            get
            {
                return TradeList.Count;
            }
        }

        public double BestBiddingPrice
        {
            get
            {
                var order = Asks.
                    Where(x => x.Type == OrderType.Limit).
                    OrderByDescending(x => x.Price).
                    FirstOrDefault();

                if (order != null)
                {
                    return order.Price;
                }
                return double.NaN;
            }
        }

        public double BestAskPrice
        {
            get
            {
                var order = Asks.
                    Where(x => x.Type == OrderType.Limit).
                    OrderBy(x => x.Price).
                    FirstOrDefault();

                if (order != null)
                {
                    return order.Price;
                }
                return double.NaN;

            }
        }

        public long TotalQuantityTraded
        {
            get
            {
                return TradeList.Sum(x => x.Quantity);
            }
        }

        public long OrderProcessed { get; private set; }

        private object _submitlock = new object();

        private object _processlock = new object();

        public delegate void TradeCompletedHandler(object sender, TradeCompletedEventArgs e);

        public event TradeCompletedHandler TradeCompleted;

        public OrderBook(string symbol, string exchange)
        {
            Symbol = symbol;

            Exchange = exchange;

            Asks = new OrderList(symbol, MarketSide.Ask);

            Bids = new OrderList(symbol, MarketSide.Bid);

            TradeList = new List<Trade>();

            //Task.Factory.StartNew(() =>
            //{
            //    lock (_processlock)
            //    {
            //        while (true)
            //        {
            //            ProcessOrder(OrderType.Limit);
            //            System.Threading.Thread.Sleep(1000);
            //        }
            //    }
            //});
            //Task.Factory.StartNew(() =>
            //{
            //    lock (_processlock)
            //    {
            //        while (true)
            //        {
            //            ProcessOrder(OrderType.Market);
            //            System.Threading.Thread.Sleep(1000);

            //        }

            //    }
            //});

        }

        public void SubmitOrder(Order order)
        {
            var orderList = order.Transaction == TransactionType.Buy ? Bids : Asks;
            lock (_submitlock)
            {
                orderList.SubmitOrder(order);
            }
        }

        public void ProcessOrder(OrderType orderType)
        {
            var orderList = Asks.Merge(Bids);

            Order order = orderList.GetNext(orderType);
            while (order != null)
            {
                var matchingOrders = GetMatchingOrderList(order);
                if (matchingOrders.Count != 0)
                {
                    if (order.Transaction == TransactionType.Buy)
                    {
                        ExecuteTrade(order, matchingOrders.OrderBy(x => x.Price).ToList());
                    }
                    else
                    {
                        ExecuteTrade(order, matchingOrders.OrderByDescending(x => x.Price).ToList());
                    }
                    OrderProcessed++;
                }
                else
                {
                    break;
                }

                order = orderList.GetNext(orderType);
            }


        }

        public OrderList GetMatchingOrderList(Order order)
        {
            var orderlist = order.Transaction == TransactionType.Buy ? Asks : Bids;
            List<Order> matchingOrders = null;
            if (order.Type == OrderType.Limit)
            {
                if (order.Transaction == TransactionType.Buy)
                {
                    matchingOrders = orderlist.Where(ord => ord.Price <= order.Price && ord.Status != OrderStatus.Completed).ToList();
                }
                else
                {
                    matchingOrders = orderlist.Where(ord => ord.Price >= order.Price && ord.Status != OrderStatus.Completed).ToList();
                }
            }
            else
            {
                if (order.Transaction == TransactionType.Buy)
                {
                    matchingOrders = orderlist.Where(ord => ord.Status != OrderStatus.Completed).ToList();
                }
                else
                {
                    matchingOrders = orderlist.Where(ord => ord.Status != OrderStatus.Completed).ToList();
                }

            }

            OrderList result = new OrderList(order.Symbol, MarketSide.Ask);

            foreach (var item in matchingOrders)
            {
                result.Add(item);
            }

            return result;
        }

        public void ExecuteTrade(Order order, List<Order> matchingOrders)
        {
            Trade trade = new Trade(order.Symbol, order.Exchange);
            long quantityRequired = order.Quantity;
            //if (order.Transaction == TransactionType.Buy)
            {
                foreach (var sOrder in matchingOrders)
                {
                    //Single seller has sufficient Quantity
                    if (quantityRequired <= sOrder.Quantity)
                    {
                        trade.UpdateTrade(sOrder.Price, quantityRequired);
                    }
                    else
                    {
                        trade.UpdateTrade(sOrder.Price, sOrder.Quantity);
                    }
                    if (quantityRequired == trade.Quantity || sOrder.Quantity == trade.Quantity)
                    {
                        //Trade Finished
                        TradeCompleted?.Invoke(this, new TradeCompletedEventArgs(trade));
                        if (order.Quantity == trade.Quantity)
                        {
                            sOrder.Quantity -= trade.Quantity;
                            order.Status = OrderStatus.Completed;
                            order.OrderSubmitted(OrderStatus.Completed);
                            if (sOrder.Quantity == 0)
                                sOrder.Status = OrderStatus.Completed;
                        }
                        else
                        {
                            order.Quantity -= trade.Quantity;
                            sOrder.Status = OrderStatus.Completed;
                            sOrder.OrderSubmitted(OrderStatus.Completed);
                        }
                        break;
                    }
                }
                TradeList.Add(trade);

            }
        }

        public OrderBookStats GetOrderBookStats()
        {
            var stats = new OrderBookStats
            {
                BestAskPrice = this.BestAskPrice,
                BestBidPrice = this.BestBiddingPrice,
                CompletedBuyOrder = this.CompletedBuyOrders,
                CompletedSellOrder = this.CompletedSellOrder,
                CompletedTrades = this.CompletedTrades,
                ProcessedOrder = this.OrderProcessed,
                TotalBuyOrder = this.TotalBuyOrders,
                TotalLimitOrder = this.TotalLimitOrders,
                TotalMarketOrder = this.TotalMarketOrders,
                TotalOrders = this.TotalOrders,
                TotalSellOrder = this.TotalSellOrders,
                TotalQuantityTraded = this.TotalQuantityTraded
            };
            return stats;
        }
    }

    public class TradeCompletedEventArgs : EventArgs
    {
        private double lastTradedPrice;

        private Trade _trade;

        public TradeCompletedEventArgs(Trade trade)
        {
            lastTradedPrice = trade.TradedPrice;
            _trade = trade;
        }

        public Trade TradeDetail
        {
            get
            {
                return _trade;
            }
        }
        public double LastTradedPrice
        {
            get
            {
                return lastTradedPrice;
            }
        }
    }
}
