using StockExchange.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockExchange
{
    public partial class Form1 : Form
    {
        public EventFeed ExchangeServer { get; set; }

        public Form1()
        {
            InitializeComponent();
            ExchangeServer = new EventFeed();
            Security security = new Security("SBI");
            ExchangeServer.AddSecurity(security);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Event> events = new List<Event>();
            events.Add(new Event { Code = "SBI", Exchange = "NSE", Flags = MarketSide.Ask, Price = 100.10, Time = DateTime.Now.ToFileTimeUtc(), TimeNsec = 0, Volume = 100 });
            events.Add(new Event { Code = "SBI", Exchange = "NSE", Flags = MarketSide.Ask, Price = 100.20, Time = DateTime.Now.ToFileTimeUtc(), TimeNsec = 0, Volume = 100 });
            events.Add(new Event { Code = "SBI", Exchange = "NSE", Flags = MarketSide.Ask, Price = 100.20, Time = DateTime.Now.ToFileTimeUtc(), TimeNsec = 0, Volume = 100 });
            events.Add(new Event { Code = "SBI", Exchange = "NSE", Flags = MarketSide.Ask, Price = 100.15, Time = DateTime.Now.ToFileTimeUtc(), TimeNsec = 0, Volume = 100 });
            events.Add(new Event { Code = "SBI", Exchange = "NSE", Flags = MarketSide.Ask, Price = 100.10, Time = DateTime.Now.ToFileTimeUtc(), TimeNsec = 0, Volume = 100 });

            events.Add(new Event { Code = "SBI", Exchange = "NSE", Flags = MarketSide.Bid, Price = 100.30, Time = DateTime.Now.ToFileTimeUtc(), TimeNsec = 0, Volume = 100 });
            events.Add(new Event { Code = "SBI", Exchange = "NSE", Flags = MarketSide.Bid, Price = 100.50, Time = DateTime.Now.ToFileTimeUtc(), TimeNsec = 0, Volume = 100 });
            events.Add(new Event { Code = "SBI", Exchange = "NSE", Flags = MarketSide.Bid, Price = 100.20, Time = DateTime.Now.ToFileTimeUtc(), TimeNsec = 0, Volume = 100 });
            events.Add(new Event { Code = "SBI", Exchange = "NSE", Flags = MarketSide.Bid, Price = 100.25, Time = DateTime.Now.ToFileTimeUtc(), TimeNsec = 0, Volume = 100 });
            events.Add(new Event { Code = "SBI", Exchange = "NSE", Flags = MarketSide.Bid, Price = 100.60, Time = DateTime.Now.ToFileTimeUtc(), TimeNsec = 0, Volume = 100 });


            foreach (var eventItem in events)
            {
                ExchangeServer.EventRecived(eventItem);
            }

            ExchangeServer.ProcessOrders();

        }
    }
}
