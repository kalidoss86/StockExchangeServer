using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange.Model
{
    public static class ExtensionClass
    {
        public static Order ToOrder(this Event item)
        {
            return new Order(item.Flags, item.Price, item.Volume, DateTime.FromFileTime(item.Time));
        }
    }
}
