using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange.Model
{
    public struct Event
    {
        public string Code;
        public string Exchange;
        public MarketSide Flags;
        public double Price;
        public long Time;
        public int TimeNsec;
        public long Volume;

    }
}
