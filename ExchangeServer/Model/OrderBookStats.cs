using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeServer.Model
{
    public class OrderBookStats
    {
        public long TotalOrders { get; set; }

        public long ProcessedOrder { get; set; }

        public long TotalLimitOrder { get; set; }

        public long TotalMarketOrder { get; set; }

        public long TotalBuyOrder { get; set; }

        public long TotalSellOrder { get; set; }

        public long CompletedBuyOrder { get; set; }

        public long CompletedSellOrder { get; set; }

        public long CompletedTrades { get; set; }

        public double BestBidPrice { get; set; }

        public double BestAskPrice { get; set; }

        public long TotalQuantityTraded { get; set; }
    }
}
