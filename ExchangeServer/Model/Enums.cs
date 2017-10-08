using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeServer.Model
{
    public enum TransactionType
    {
        Buy,
        Sell
    }

    public enum OrderType
    {
        Market,
        Limit
    }

    public enum OrderStatus
    {
        Open,
        Completed,
        Cancelled,
        TriggerPending
    }

    public enum MarketSide
    {
        Ask,
        Bid
    }
}
