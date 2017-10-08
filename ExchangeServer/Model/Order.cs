using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeServer.Model
{
    public class Order
    {
        public string ClientId { get; set; }

        public string Symbol { get; set; }

        public string Exchange { get; set; }

        public TransactionType Transaction { get; set; }

        public DateTime TimeStamp { get; set; }

        public OrderType Type { get; set; }

        public double Price { get; set; }

        public long Quantity { get; set; }

        public OrderStatus Status { get; set; }

        public delegate void OrderStatusHandler(object sender, OrderStatusEventArgs e);

        public event OrderStatusHandler OrderStatusEvent;

        public Order()
        {

        }

        public Order(string id, string symbol, string exchange, TransactionType transactionType, OrderType type, double price, long quantity)
        {
            ClientId = id;
            Symbol = symbol;
            Exchange = exchange;
            Transaction = transactionType;
            Type = type;
            Price = price;
            Quantity = quantity;
        }

        public void OrderSubmitted(OrderStatus orderStatus)
        {
            OrderStatusEvent?.Invoke(this, new OrderStatusEventArgs(orderStatus));
        }
    }

    public class OrderStatusEventArgs : EventArgs
    {
        private OrderStatus orderStatus;

        public OrderStatusEventArgs(OrderStatus status)
        {
            orderStatus = status;
        }

        public OrderStatus OrderStatus
        {
            get
            {
                return orderStatus;
            }
        }
    }
}
