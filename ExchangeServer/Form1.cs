using ExchangeServer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExchangeServer
{
    public partial class Form1 : Form
    {

        private delegate void AddListViewItemDelegate(ListView listView, object item);

        private delegate void UpdateChartDelegate(Chart chart, double price, DateTime timestamp);

        private delegate void UpdateStatusLabelDelegate(Label label, string text);

        private object _lock = new object();

        private Series priceSeries = null;

        public List<Client> ClientList { get; set; }

        public Form1()
        {
            InitializeComponent();

            listViewAsks.View = View.Details;
            listViewAsks.GridLines = true;
            listViewAsks.FullRowSelect = true;

            listViewBids.View = View.Details;
            listViewBids.GridLines = true;
            listViewBids.FullRowSelect = true;

            listViewLastTradePrice.View = View.Details;
            listViewLastTradePrice.GridLines = true;
            listViewLastTradePrice.FullRowSelect = true;

            listViewAsks.Columns.Add("Time", 100);
            listViewAsks.Columns.Add("Quantity", 100);
            listViewAsks.Columns.Add("Ask", 100);

            listViewBids.Columns.Add("Time", 100);
            listViewBids.Columns.Add("Quantity", 100);
            listViewBids.Columns.Add("Bid", 100);


            listViewLastTradePrice.Columns.Add("Time", 100);
            listViewLastTradePrice.Columns.Add("Quantity", 100);
            listViewLastTradePrice.Columns.Add("Last Traded Price", 100);

            chartPrice.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            priceSeries = chartPrice.Series.Add("price");
            priceSeries.ChartType = SeriesChartType.Line;
            priceSeries.Color = Color.DarkGreen;
            priceSeries.XValueType = ChartValueType.Time;
            //priceSeries.MarkerStyle = MarkerStyle.Circle;

        }

        private void Form1_LoadAsync(object sender, EventArgs e)
        {
            Exchange bangaloreExchange = new Exchange();

            //bangaloreExchange.AddSecurity("SBI");

            bangaloreExchange.OrderPlaced += BangaloreExchange_OrderPlaced;

            bangaloreExchange.TradeExecuted += BangaloreExchange_TradeExecuted;

            GenerateRandomQuantity(12345, 100);

            List<Order> Orders = new List<Order>();

            //Orderlist.Add(new Order { ClientId = "1", Exchange = "NSE", Price = 100.10, Quantity = 12000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Buy, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "15", Exchange = "NSE", Price = 90.00, Quantity = 20000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Sell, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "2", Exchange = "NSE", Price = 100.20, Quantity = 300000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Buy, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "11", Exchange = "NSE", Price = 100.50, Quantity = 1000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Sell, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "3", Exchange = "NSE", Price = 100.15, Quantity = 500000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Buy, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "13", Exchange = "NSE", Price = 100.10, Quantity = 50000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Sell, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "3", Exchange = "NSE", Price = 100.15, Quantity = 500000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Buy, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "13", Exchange = "NSE", Price = 100.10, Quantity = 50000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Sell, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "4", Exchange = "NSE", Price = 90.05, Quantity = 23000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Buy, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "2", Exchange = "NSE", Price = 100.20, Quantity = 300000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Buy, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "5", Exchange = "NSE", Price = 99.95, Quantity = 32000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Buy, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "6", Exchange = "NSE", Price = 100.00, Quantity = 10000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Buy, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "11", Exchange = "NSE", Price = 100.50, Quantity = 1000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Sell, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "14", Exchange = "NSE", Price = 100.20, Quantity = 150000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Sell, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "3", Exchange = "NSE", Price = 100.15, Quantity = 500000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Buy, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "13", Exchange = "NSE", Price = 100.10, Quantity = 50000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Sell, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "3", Exchange = "NSE", Price = 100.15, Quantity = 500000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Buy, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "13", Exchange = "NSE", Price = 100.10, Quantity = 50000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Sell, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "4", Exchange = "NSE", Price = 90.05, Quantity = 23000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Buy, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "12", Exchange = "NSE", Price = 100.00, Quantity = 1000000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Sell, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "5", Exchange = "NSE", Price = 99.95, Quantity = 32000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Buy, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "6", Exchange = "NSE", Price = 100.00, Quantity = 10000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Buy, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "7", Exchange = "NSE", Price = 100.05, Quantity = 35000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Buy, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "8", Exchange = "NSE", Price = 100.10, Quantity = 30000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Buy, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "9", Exchange = "NSE", Price = 100.20, Quantity = 200000, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Buy, Type = OrderType.Limit });
            //Orderlist.Add(new Order { ClientId = "10", Exchange = "NSE", Price = 101.00, Quantity = 500, Status = OrderStatus.Open, Symbol = "SBI", TimeStamp = DateTime.Now, Transaction = TransactionType.Sell, Type = OrderType.Limit });

            Orders.Add(new Order
            {
                ClientId = "9",
                Exchange = "NSE",
                Price = 100.10,
                Quantity = 200,
                Status = OrderStatus.Open,
                Symbol = "SBI",
                TimeStamp = DateTime.Now,
                Transaction = TransactionType.Buy,
                Type = OrderType.Limit
            });
            Orders.Add(new Order
            {
                ClientId = "9",
                Exchange = "NSE",
                Price = 100.20,
                Quantity = 200,
                Status = OrderStatus.Open,
                Symbol = "SBI",
                TimeStamp = DateTime.Now,
                Transaction = TransactionType.Buy,
                Type = OrderType.Market
            });
            Orders.Add(new Order
            {
                ClientId = "9",
                Exchange = "NSE",
                Price = 101.20,
                Quantity = 100,
                Status = OrderStatus.Open,
                Symbol = "SBI",
                TimeStamp = DateTime.Now,
                Transaction = TransactionType.Buy,
                Type = OrderType.Limit
            });
            Orders.Add(new Order
            {
                ClientId = "10",
                Exchange = "NSE",
                Price = 99.00,
                Quantity = 100,
                Status = OrderStatus.Open,
                Symbol = "SBI",
                TimeStamp = DateTime.Now,
                Transaction = TransactionType.Sell,
                Type = OrderType.Limit
            });
            Orders.Add(new Order
            {
                ClientId = "10",
                Exchange = "NSE",
                Price = 100.00,
                Quantity = 300,
                Status = OrderStatus.Open,
                Symbol = "SBI",
                TimeStamp = DateTime.Now,
                Transaction = TransactionType.Sell,
                Type = OrderType.Market
            });

            Task.Factory.StartNew(() =>
            {
                var orders = GenerateRandomOrderList("SBI", "NSE", 105.00, 90.00, 10000);
                foreach (var order in orders)
                //foreach (var order in Orders)
                {
                    lock (_lock)
                    {
                        OrderFeed(bangaloreExchange, order);
                    }
                }
            });

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    lock (_lock)
                    {
                        bangaloreExchange.StartOrderProcessing(OrderType.Market);
                    }
                    System.Threading.Thread.Sleep(100);
                }
            });

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    lock (_lock)
                    {
                        bangaloreExchange.StartOrderProcessing(OrderType.Limit);
                    }
                    System.Threading.Thread.Sleep(100);
                }
            });

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    if (bangaloreExchange.Securities.TryGetValue("SBI", out Security security))
                        UpdateChartPrice(chartPrice, security.LastTradedPrice, DateTime.Now);
                    System.Threading.Thread.Sleep(5000);
                }
            });

            Task.Factory.StartNew(() =>
           {
               while (true)
               {
                   if (bangaloreExchange.Securities.TryGetValue("SBI", out Security security))
                   {
                       if (security.OrderBook.TryGetValue("SBI", out OrderBook orderbook))
                       {
                           OrderBookStats stats;
                           lock (_lock)
                           {
                               stats = orderbook.GetOrderBookStats();

                           }
                           UpdateStatLabel(lblTotalOrdersVal, stats.TotalOrders.ToString());
                           UpdateStatLabel(lblBestAskPriceVal, stats.BestAskPrice.ToString("0.##"));
                           UpdateStatLabel(lblBestBidPriceVal , stats.BestBidPrice.ToString("0.##"));
                           UpdateStatLabel(lblCompletedBuyOrderVal, stats.CompletedBuyOrder.ToString());
                           UpdateStatLabel(lblCompletedSellOrderVal, stats.CompletedSellOrder.ToString());
                           UpdateStatLabel(lblCompletedTradesVal, stats.CompletedTrades.ToString());
                           UpdateStatLabel(lblTotalBuyOrderVal, stats.TotalBuyOrder.ToString());
                           UpdateStatLabel(lblTotalLimitOrderVal, stats.TotalLimitOrder.ToString());
                           UpdateStatLabel(lblTotalMarketOrderVal, stats.TotalMarketOrder.ToString());
                           UpdateStatLabel(lblTotalSellOrderVal, stats.TotalSellOrder.ToString());
                           UpdateStatLabel(lblProcessedOrderVal, stats.ProcessedOrder.ToString());
                           UpdateStatLabel(lblTotalQuatityTradedVal, stats.TotalQuantityTraded.ToString());
                           System.Threading.Thread.Sleep(100);
                       }
                   }
               }
           });
        }

        private static void OrderFeed(Exchange bangaloreExchange, Order order)
        {
            bangaloreExchange.PlaceOrder(order);
            System.Threading.Thread.Sleep(100);
        }

        private static void GenerateClients()
        {

        }

        private static void GenerateRandomQuantity(int sum, int count)
        {
            long[] result = new long[count];
            Random rand = new Random();
            long x = sum / count;

            for (int i = 0; i < count; i++)
            {
                result[i] = x;
            }

            for (int i = 0; i < x; i++)
            {
                var a = rand.Next(count - 1);
                var b = rand.Next(count - 1);

                result[a]++;
                result[b]--;
            }

            System.Diagnostics.Debug.Print(result.Sum().ToString());
        }

        private void BangaloreExchange_TradeExecuted(object sender, TradedPriceEventArgs e)
        {

            string[] arr = new string[3];
            arr[0] = e.TimeStamp.ToLongTimeString();
            arr[1] = e.Quantity.ToString();
            arr[2] = e.LastTradedPrice.ToString("0.##");


            ListViewItem item = new ListViewItem(arr);

            AddListViewItem(listViewLastTradePrice, item);
            //UpdateChartPrice(chartPrice, e.LastTradedPrice, e.TimeStamp);
            //listViewLastTradePrice.Items.Add(item);
        }

        private void BangaloreExchange_OrderPlaced(object sender, OrderPlacedEventArgs e)
        {
            var order = e.OrderDetail;

            string[] arr = new string[3];

            arr[0] = order.TimeStamp.ToLongTimeString();
            arr[1] = order.Quantity.ToString();
            arr[2] = order.Price.ToString("0.##");

            ListViewItem item = new ListViewItem(arr);

            if (order.Transaction == TransactionType.Buy)
            {
                AddListViewItem(listViewBids, item);
                //listViewBids.Items.Add(item);
            }
            else
            {
                AddListViewItem(listViewAsks, item);
                //listViewAsks.Items.Add(item);
            }


        }

        private static void AddListViewItem(ListView listView, object item)
        {
            if (listView.InvokeRequired)
            {
                listView.Invoke(new AddListViewItemDelegate(AddListViewItem), listView, item);
            }
            else
            {
                listView.Items.Insert(0, item as ListViewItem);
            }
        }

        private void UpdateChartPrice(Chart chart, double price, DateTime timestamp)
        {
            if (chart.InvokeRequired)
            {
                chart.Invoke(new UpdateChartDelegate(UpdateChartPrice), chart, price, timestamp);
            }
            else
            {
                priceSeries.Points.AddXY(timestamp, price);
                chartPrice.ChartAreas[0].AxisY.Maximum = Math.Ceiling(priceSeries.Points.FindMaxByValue().YValues[0]) + 2;
                chartPrice.ChartAreas[0].AxisY.Minimum = Math.Floor(priceSeries.Points.FindMinByValue().YValues[0]) - 2;
                chartPrice.ChartAreas[0].RecalculateAxesScale();
            }
        }

        private void UpdateStatLabel(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new UpdateStatusLabelDelegate(UpdateStatLabel), label, text);
            }
            else
            {
                label.Text = text;
            }
        }


        private static OrderList GenerateRandomOrderList(string symbol, string exchange, double priceHigh, double priceLow, int count)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            OrderList orderList = new OrderList(symbol, MarketSide.Ask);
            for (int i = 0; i < count; i++)
            {
                orderList.Add(new Order
                {
                    ClientId = rand.Next(1, 100).ToString(),
                    Exchange = exchange,
                    Quantity = rand.Next(100, 500000),
                    Status = OrderStatus.Open,
                    Symbol = symbol,
                    TimeStamp = DateTime.Now,
                    Transaction = rand.Next(0, 2) == 0 ? TransactionType.Buy : TransactionType.Sell,
                    Type = rand.Next(0, 2) == 0 ? OrderType.Limit : OrderType.Market,
                    Price = rand.NextDouble() * (priceHigh - priceLow) + priceLow

                });

            }

            return orderList;

        }
    }
}
