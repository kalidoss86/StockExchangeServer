using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeServer.Model
{
    public class Client
    {
        public string Id { get; set; }

        public double MarginAvailable { get; set; }

        public List<Position> Positions { get; set; }

        public List<Order> OrderBook { get; set; }

        public Client(string id)
        {
            Id = id;
            MarginAvailable = 0;
            Positions = new List<Position>();
            OrderBook = new List<Order>();
        }

        public double AddCash(double cash)
        {
            MarginAvailable += cash;
            return MarginAvailable;
        }

        public double WithdrawCash(double amount)
        {
            MarginAvailable -= amount;
            return MarginAvailable;
        }

        public Order BuyOrder(string symbol, string exchange, OrderType orderType, double price, long quantity)
        {
            var orderform = new Order(Id, symbol, exchange, TransactionType.Buy, orderType, price, quantity);

            return orderform;
        }
        public Order SellOrder(string symbol, string exchange, OrderType orderType, double price, long quantity)
        {
            var orderform = new Order(Id, symbol, exchange, TransactionType.Sell, orderType, price, quantity);

            return orderform;
        }
    }
}
