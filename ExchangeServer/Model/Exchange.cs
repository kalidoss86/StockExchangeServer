using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeServer.Model
{
    public class Exchange
    {
        public Dictionary<string, Security> Securities { get; set; }

        public delegate void OrderPlacedHander(object sender, OrderPlacedEventArgs e);

        public event OrderPlacedHander OrderPlaced;

        public delegate void TradePriceHandler(object sender, TradedPriceEventArgs e);

        public event TradePriceHandler TradeExecuted;

        public Exchange()
        {
            Securities = new Dictionary<string, Security>();
        }

        public void PlaceOrder(Order order)
        {
            //Check the security is already there in list otherwise add it.
            Security security;
            if (!Securities.TryGetValue(order.Symbol, out security))
            {
                security = AddSecurity(order.Symbol, 256.75, 2216278800000);
                security.TradeCompleted += Security_TradeCompleted;
                
                //foreach (var orderbook in security.OrderBook)
                //{
                //    var ordBook = orderbook.Value;
                //    ordBook.TradeCompleted += OrderBook_TradeCompleted;
                //}

            }

            if (security != null)
            {
                //Send the Order to Security
                security.SubmitOrder(order);
                OrderPlaced?.Invoke(this, new OrderPlacedEventArgs(order));
            }
        }

        private void Security_TradeCompleted(object sender, TradeCompletedEventArgs e)
        {
            TradeExecuted?.Invoke(this, new TradedPriceEventArgs(e.TradeDetail));
        }


        public Security AddSecurity(string symbol, double lasttradedprice, long marketcap)
        {
            var securty = new Security(symbol, lasttradedprice, marketcap);

            Securities.Add(symbol, securty);

            return securty;
        }

        public void AddSecurity(Security security)
        {
            Securities.Add(security.Symbol, security);
        }

        public void StartOrderProcessing(OrderType orderType)
        {
            foreach (var security in Securities)
            {
                security.Value.ProcessOrder(orderType);
            }
        }
    }

    public class TradedPriceEventArgs : EventArgs
    {
        Trade _trade;

        public TradedPriceEventArgs(Trade trade)
        {
            _trade = trade;
        }

        public DateTime TimeStamp
        {
            get
            {
                return _trade.TimeStamp;
            }
        }

        public double LastTradedPrice
        {
            get
            {
                return _trade.TradedPrice;
            }
        }

        public long Quantity
        {
            get
            {
                return _trade.Quantity;
            }
        }
    }

    public class OrderPlacedEventArgs : EventArgs
    {
        Order _order;
        public OrderPlacedEventArgs(Order order)
        {
            _order = order;
        }

        public Order OrderDetail
        {
            get
            {
                return _order;
            }

        }
    }
}
