using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange.Model
{
    public class EventFeed
    {
        public Dictionary<string, Security> Securities { get; set; }

        public int TotalEventsProcessed { get; set; }

        public EventFeed()
        {
            Securities = new Dictionary<string, Security>();
        }

        public void EventRecived(Event eventItem)
        {
            TotalEventsProcessed++;

            Security security;
            if(!Securities.TryGetValue(eventItem.Code, out security))
            {
                security = AddSecurity(eventItem.Code);
            }

            if (security != null)
            {
                security.EventRecieved(eventItem);
            }

        }

        public void ProcessOrders()
        {
            foreach (var security in Securities)
            {
                var orders = security.Value;
                var orderBook = orders.OrderBook;
                
                foreach (var orderItem in orderBook)
                {
                    var item = orderItem.Value;
                    item.MatchTrade();
                }
            }
        }

        public void AddSecurity(Security security)
        {
            Securities.Add(security.Symbol, security);
        }

        public Security AddSecurity(string securitySymbol)
        {
            Security security = new Security(securitySymbol);
            Securities.Add(securitySymbol, security);
            return security;
        }

        public void RemoveSecurity(Security security)
        {
            Securities.Remove(security.Symbol);
        }

        public void RemoveSecurity(string securitySymbol)
        {
            Securities.Remove(securitySymbol);
        }
    }
}
