namespace ExchangeServer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewAsks = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewLastTradePrice = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listViewBids = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chartPrice = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tblLayoutStatistics = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalOrdersVal = new System.Windows.Forms.Label();
            this.lblProcessedOrderVal = new System.Windows.Forms.Label();
            this.lblProcessedOrder = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblTotalLimitOrder = new System.Windows.Forms.Label();
            this.lblTotalLimitOrderVal = new System.Windows.Forms.Label();
            this.lblTotalMarketOrder = new System.Windows.Forms.Label();
            this.lblTotalMarketOrderVal = new System.Windows.Forms.Label();
            this.lblTotalBuyOrder = new System.Windows.Forms.Label();
            this.lblTotalBuyOrderVal = new System.Windows.Forms.Label();
            this.lblTotalSellOrder = new System.Windows.Forms.Label();
            this.lblTotalSellOrderVal = new System.Windows.Forms.Label();
            this.lblCompletedBuyOrder = new System.Windows.Forms.Label();
            this.lblCompletedBuyOrderVal = new System.Windows.Forms.Label();
            this.lblCompletedSellOrder = new System.Windows.Forms.Label();
            this.lblCompletedSellOrderVal = new System.Windows.Forms.Label();
            this.lblCompletedTrades = new System.Windows.Forms.Label();
            this.lblCompletedTradesVal = new System.Windows.Forms.Label();
            this.lblBestBidPrice = new System.Windows.Forms.Label();
            this.lblBestBidPriceVal = new System.Windows.Forms.Label();
            this.lblBestAskPrice = new System.Windows.Forms.Label();
            this.lblBestAskPriceVal = new System.Windows.Forms.Label();
            this.lblTotalQuatityTraded = new System.Windows.Forms.Label();
            this.lblTotalQuatityTradedVal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice)).BeginInit();
            this.panel5.SuspendLayout();
            this.tblLayoutStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1041, 685);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewAsks);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 336);
            this.panel1.TabIndex = 0;
            // 
            // listViewAsks
            // 
            this.listViewAsks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAsks.Location = new System.Drawing.Point(13, 25);
            this.listViewAsks.Name = "listViewAsks";
            this.listViewAsks.Size = new System.Drawing.Size(347, 308);
            this.listViewAsks.TabIndex = 1;
            this.listViewAsks.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ask";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewLastTradePrice);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(372, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 336);
            this.panel2.TabIndex = 1;
            // 
            // listViewLastTradePrice
            // 
            this.listViewLastTradePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewLastTradePrice.Location = new System.Drawing.Point(10, 25);
            this.listViewLastTradePrice.Name = "listViewLastTradePrice";
            this.listViewLastTradePrice.Size = new System.Drawing.Size(350, 308);
            this.listViewLastTradePrice.TabIndex = 1;
            this.listViewLastTradePrice.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Traded Price";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listViewBids);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 345);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 337);
            this.panel3.TabIndex = 2;
            // 
            // listViewBids
            // 
            this.listViewBids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewBids.Location = new System.Drawing.Point(7, 25);
            this.listViewBids.Name = "listViewBids";
            this.listViewBids.Size = new System.Drawing.Size(356, 309);
            this.listViewBids.TabIndex = 1;
            this.listViewBids.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bid";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.chartPrice);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(372, 345);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 337);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price Chart";
            // 
            // chartPrice
            // 
            this.chartPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "ChartArea1";
            this.chartPrice.ChartAreas.Add(chartArea1);
            this.chartPrice.Location = new System.Drawing.Point(7, 24);
            this.chartPrice.Name = "chartPrice";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            this.chartPrice.Series.Add(series1);
            this.chartPrice.Size = new System.Drawing.Size(353, 310);
            this.chartPrice.TabIndex = 0;
            this.chartPrice.Text = "chart1";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tblLayoutStatistics);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(741, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(297, 336);
            this.panel5.TabIndex = 4;
            // 
            // tblLayoutStatistics
            // 
            this.tblLayoutStatistics.ColumnCount = 2;
            this.tblLayoutStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutStatistics.Controls.Add(this.lblTotalOrdersVal, 1, 0);
            this.tblLayoutStatistics.Controls.Add(this.lblProcessedOrderVal, 1, 1);
            this.tblLayoutStatistics.Controls.Add(this.lblProcessedOrder, 0, 1);
            this.tblLayoutStatistics.Controls.Add(this.lblTotalOrders, 0, 0);
            this.tblLayoutStatistics.Controls.Add(this.lblTotalLimitOrder, 0, 2);
            this.tblLayoutStatistics.Controls.Add(this.lblTotalLimitOrderVal, 1, 2);
            this.tblLayoutStatistics.Controls.Add(this.lblTotalMarketOrder, 0, 3);
            this.tblLayoutStatistics.Controls.Add(this.lblTotalMarketOrderVal, 1, 3);
            this.tblLayoutStatistics.Controls.Add(this.lblTotalBuyOrder, 0, 4);
            this.tblLayoutStatistics.Controls.Add(this.lblTotalBuyOrderVal, 1, 4);
            this.tblLayoutStatistics.Controls.Add(this.lblTotalSellOrder, 0, 5);
            this.tblLayoutStatistics.Controls.Add(this.lblTotalSellOrderVal, 1, 5);
            this.tblLayoutStatistics.Controls.Add(this.lblCompletedBuyOrder, 0, 6);
            this.tblLayoutStatistics.Controls.Add(this.lblCompletedBuyOrderVal, 1, 6);
            this.tblLayoutStatistics.Controls.Add(this.lblCompletedSellOrder, 0, 7);
            this.tblLayoutStatistics.Controls.Add(this.lblCompletedSellOrderVal, 1, 7);
            this.tblLayoutStatistics.Controls.Add(this.lblCompletedTrades, 0, 8);
            this.tblLayoutStatistics.Controls.Add(this.lblCompletedTradesVal, 1, 8);
            this.tblLayoutStatistics.Controls.Add(this.lblBestBidPrice, 0, 9);
            this.tblLayoutStatistics.Controls.Add(this.lblBestBidPriceVal, 1, 9);
            this.tblLayoutStatistics.Controls.Add(this.lblBestAskPrice, 0, 10);
            this.tblLayoutStatistics.Controls.Add(this.lblBestAskPriceVal, 1, 10);
            this.tblLayoutStatistics.Controls.Add(this.lblTotalQuatityTraded, 0, 11);
            this.tblLayoutStatistics.Controls.Add(this.lblTotalQuatityTradedVal, 1, 11);
            this.tblLayoutStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutStatistics.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutStatistics.Name = "tblLayoutStatistics";
            this.tblLayoutStatistics.RowCount = 12;
            this.tblLayoutStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblLayoutStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblLayoutStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblLayoutStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblLayoutStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblLayoutStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblLayoutStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblLayoutStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblLayoutStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblLayoutStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblLayoutStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblLayoutStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblLayoutStatistics.Size = new System.Drawing.Size(297, 336);
            this.tblLayoutStatistics.TabIndex = 0;
            // 
            // lblTotalOrdersVal
            // 
            this.lblTotalOrdersVal.AutoSize = true;
            this.lblTotalOrdersVal.Location = new System.Drawing.Point(151, 0);
            this.lblTotalOrdersVal.Name = "lblTotalOrdersVal";
            this.lblTotalOrdersVal.Size = new System.Drawing.Size(0, 17);
            this.lblTotalOrdersVal.TabIndex = 1;
            // 
            // lblProcessedOrderVal
            // 
            this.lblProcessedOrderVal.AutoSize = true;
            this.lblProcessedOrderVal.Location = new System.Drawing.Point(151, 27);
            this.lblProcessedOrderVal.Name = "lblProcessedOrderVal";
            this.lblProcessedOrderVal.Size = new System.Drawing.Size(0, 17);
            this.lblProcessedOrderVal.TabIndex = 3;
            // 
            // lblProcessedOrder
            // 
            this.lblProcessedOrder.AutoSize = true;
            this.lblProcessedOrder.Location = new System.Drawing.Point(3, 27);
            this.lblProcessedOrder.Name = "lblProcessedOrder";
            this.lblProcessedOrder.Size = new System.Drawing.Size(112, 17);
            this.lblProcessedOrder.TabIndex = 2;
            this.lblProcessedOrder.Text = "ProcessedOrder";
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Location = new System.Drawing.Point(3, 0);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(84, 17);
            this.lblTotalOrders.TabIndex = 0;
            this.lblTotalOrders.Text = "TotalOrders";
            // 
            // lblTotalLimitOrder
            // 
            this.lblTotalLimitOrder.AutoSize = true;
            this.lblTotalLimitOrder.Location = new System.Drawing.Point(3, 54);
            this.lblTotalLimitOrder.Name = "lblTotalLimitOrder";
            this.lblTotalLimitOrder.Size = new System.Drawing.Size(106, 17);
            this.lblTotalLimitOrder.TabIndex = 4;
            this.lblTotalLimitOrder.Text = "TotalLimitOrder";
            // 
            // lblTotalLimitOrderVal
            // 
            this.lblTotalLimitOrderVal.AutoSize = true;
            this.lblTotalLimitOrderVal.Location = new System.Drawing.Point(151, 54);
            this.lblTotalLimitOrderVal.Name = "lblTotalLimitOrderVal";
            this.lblTotalLimitOrderVal.Size = new System.Drawing.Size(0, 17);
            this.lblTotalLimitOrderVal.TabIndex = 5;
            // 
            // lblTotalMarketOrder
            // 
            this.lblTotalMarketOrder.AutoSize = true;
            this.lblTotalMarketOrder.Location = new System.Drawing.Point(3, 81);
            this.lblTotalMarketOrder.Name = "lblTotalMarketOrder";
            this.lblTotalMarketOrder.Size = new System.Drawing.Size(120, 17);
            this.lblTotalMarketOrder.TabIndex = 6;
            this.lblTotalMarketOrder.Text = "TotalMarketOrder";
            // 
            // lblTotalMarketOrderVal
            // 
            this.lblTotalMarketOrderVal.AutoSize = true;
            this.lblTotalMarketOrderVal.Location = new System.Drawing.Point(151, 81);
            this.lblTotalMarketOrderVal.Name = "lblTotalMarketOrderVal";
            this.lblTotalMarketOrderVal.Size = new System.Drawing.Size(0, 17);
            this.lblTotalMarketOrderVal.TabIndex = 7;
            // 
            // lblTotalBuyOrder
            // 
            this.lblTotalBuyOrder.AutoSize = true;
            this.lblTotalBuyOrder.Location = new System.Drawing.Point(3, 108);
            this.lblTotalBuyOrder.Name = "lblTotalBuyOrder";
            this.lblTotalBuyOrder.Size = new System.Drawing.Size(101, 17);
            this.lblTotalBuyOrder.TabIndex = 8;
            this.lblTotalBuyOrder.Text = "TotalBuyOrder";
            // 
            // lblTotalBuyOrderVal
            // 
            this.lblTotalBuyOrderVal.AutoSize = true;
            this.lblTotalBuyOrderVal.Location = new System.Drawing.Point(151, 108);
            this.lblTotalBuyOrderVal.Name = "lblTotalBuyOrderVal";
            this.lblTotalBuyOrderVal.Size = new System.Drawing.Size(0, 17);
            this.lblTotalBuyOrderVal.TabIndex = 9;
            // 
            // lblTotalSellOrder
            // 
            this.lblTotalSellOrder.AutoSize = true;
            this.lblTotalSellOrder.Location = new System.Drawing.Point(3, 135);
            this.lblTotalSellOrder.Name = "lblTotalSellOrder";
            this.lblTotalSellOrder.Size = new System.Drawing.Size(100, 17);
            this.lblTotalSellOrder.TabIndex = 10;
            this.lblTotalSellOrder.Text = "TotalSellOrder";
            // 
            // lblTotalSellOrderVal
            // 
            this.lblTotalSellOrderVal.AutoSize = true;
            this.lblTotalSellOrderVal.Location = new System.Drawing.Point(151, 135);
            this.lblTotalSellOrderVal.Name = "lblTotalSellOrderVal";
            this.lblTotalSellOrderVal.Size = new System.Drawing.Size(0, 17);
            this.lblTotalSellOrderVal.TabIndex = 11;
            // 
            // lblCompletedBuyOrder
            // 
            this.lblCompletedBuyOrder.AutoSize = true;
            this.lblCompletedBuyOrder.Location = new System.Drawing.Point(3, 162);
            this.lblCompletedBuyOrder.Name = "lblCompletedBuyOrder";
            this.lblCompletedBuyOrder.Size = new System.Drawing.Size(136, 17);
            this.lblCompletedBuyOrder.TabIndex = 12;
            this.lblCompletedBuyOrder.Text = "CompletedBuyOrder";
            // 
            // lblCompletedBuyOrderVal
            // 
            this.lblCompletedBuyOrderVal.AutoSize = true;
            this.lblCompletedBuyOrderVal.Location = new System.Drawing.Point(151, 162);
            this.lblCompletedBuyOrderVal.Name = "lblCompletedBuyOrderVal";
            this.lblCompletedBuyOrderVal.Size = new System.Drawing.Size(0, 17);
            this.lblCompletedBuyOrderVal.TabIndex = 13;
            // 
            // lblCompletedSellOrder
            // 
            this.lblCompletedSellOrder.AutoSize = true;
            this.lblCompletedSellOrder.Location = new System.Drawing.Point(3, 189);
            this.lblCompletedSellOrder.Name = "lblCompletedSellOrder";
            this.lblCompletedSellOrder.Size = new System.Drawing.Size(135, 17);
            this.lblCompletedSellOrder.TabIndex = 14;
            this.lblCompletedSellOrder.Text = "CompletedSellOrder";
            // 
            // lblCompletedSellOrderVal
            // 
            this.lblCompletedSellOrderVal.AutoSize = true;
            this.lblCompletedSellOrderVal.Location = new System.Drawing.Point(151, 189);
            this.lblCompletedSellOrderVal.Name = "lblCompletedSellOrderVal";
            this.lblCompletedSellOrderVal.Size = new System.Drawing.Size(0, 17);
            this.lblCompletedSellOrderVal.TabIndex = 15;
            // 
            // lblCompletedTrades
            // 
            this.lblCompletedTrades.AutoSize = true;
            this.lblCompletedTrades.Location = new System.Drawing.Point(3, 216);
            this.lblCompletedTrades.Name = "lblCompletedTrades";
            this.lblCompletedTrades.Size = new System.Drawing.Size(120, 17);
            this.lblCompletedTrades.TabIndex = 16;
            this.lblCompletedTrades.Text = "CompletedTrades";
            // 
            // lblCompletedTradesVal
            // 
            this.lblCompletedTradesVal.AutoSize = true;
            this.lblCompletedTradesVal.Location = new System.Drawing.Point(151, 216);
            this.lblCompletedTradesVal.Name = "lblCompletedTradesVal";
            this.lblCompletedTradesVal.Size = new System.Drawing.Size(0, 17);
            this.lblCompletedTradesVal.TabIndex = 17;
            // 
            // lblBestBidPrice
            // 
            this.lblBestBidPrice.AutoSize = true;
            this.lblBestBidPrice.Location = new System.Drawing.Point(3, 243);
            this.lblBestBidPrice.Name = "lblBestBidPrice";
            this.lblBestBidPrice.Size = new System.Drawing.Size(88, 17);
            this.lblBestBidPrice.TabIndex = 18;
            this.lblBestBidPrice.Text = "BestBidPrice";
            // 
            // lblBestBidPriceVal
            // 
            this.lblBestBidPriceVal.AutoSize = true;
            this.lblBestBidPriceVal.Location = new System.Drawing.Point(151, 243);
            this.lblBestBidPriceVal.Name = "lblBestBidPriceVal";
            this.lblBestBidPriceVal.Size = new System.Drawing.Size(0, 17);
            this.lblBestBidPriceVal.TabIndex = 19;
            // 
            // lblBestAskPrice
            // 
            this.lblBestAskPrice.AutoSize = true;
            this.lblBestAskPrice.Location = new System.Drawing.Point(3, 270);
            this.lblBestAskPrice.Name = "lblBestAskPrice";
            this.lblBestAskPrice.Size = new System.Drawing.Size(91, 17);
            this.lblBestAskPrice.TabIndex = 20;
            this.lblBestAskPrice.Text = "BestAskPrice";
            // 
            // lblBestAskPriceVal
            // 
            this.lblBestAskPriceVal.AutoSize = true;
            this.lblBestAskPriceVal.Location = new System.Drawing.Point(151, 270);
            this.lblBestAskPriceVal.Name = "lblBestAskPriceVal";
            this.lblBestAskPriceVal.Size = new System.Drawing.Size(0, 17);
            this.lblBestAskPriceVal.TabIndex = 21;
            // 
            // lblTotalQuatityTraded
            // 
            this.lblTotalQuatityTraded.AutoSize = true;
            this.lblTotalQuatityTraded.Location = new System.Drawing.Point(3, 297);
            this.lblTotalQuatityTraded.Name = "lblTotalQuatityTraded";
            this.lblTotalQuatityTraded.Size = new System.Drawing.Size(131, 17);
            this.lblTotalQuatityTraded.TabIndex = 22;
            this.lblTotalQuatityTraded.Text = "TotalQuatityTraded";
            // 
            // lblTotalQuatityTradedVal
            // 
            this.lblTotalQuatityTradedVal.AutoSize = true;
            this.lblTotalQuatityTradedVal.Location = new System.Drawing.Point(151, 297);
            this.lblTotalQuatityTradedVal.Name = "lblTotalQuatityTradedVal";
            this.lblTotalQuatityTradedVal.Size = new System.Drawing.Size(0, 17);
            this.lblTotalQuatityTradedVal.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 685);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_LoadAsync);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tblLayoutStatistics.ResumeLayout(false);
            this.tblLayoutStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewAsks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listViewLastTradePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listViewBids;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrice;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tblLayoutStatistics;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblTotalOrdersVal;
        private System.Windows.Forms.Label lblProcessedOrder;
        private System.Windows.Forms.Label lblProcessedOrderVal;
        private System.Windows.Forms.Label lblTotalLimitOrder;
        private System.Windows.Forms.Label lblTotalLimitOrderVal;
        private System.Windows.Forms.Label lblTotalMarketOrder;
        private System.Windows.Forms.Label lblTotalMarketOrderVal;
        private System.Windows.Forms.Label lblTotalBuyOrder;
        private System.Windows.Forms.Label lblTotalBuyOrderVal;
        private System.Windows.Forms.Label lblTotalSellOrder;
        private System.Windows.Forms.Label lblTotalSellOrderVal;
        private System.Windows.Forms.Label lblCompletedBuyOrder;
        private System.Windows.Forms.Label lblCompletedBuyOrderVal;
        private System.Windows.Forms.Label lblCompletedSellOrder;
        private System.Windows.Forms.Label lblCompletedSellOrderVal;
        private System.Windows.Forms.Label lblCompletedTrades;
        private System.Windows.Forms.Label lblCompletedTradesVal;
        private System.Windows.Forms.Label lblBestBidPrice;
        private System.Windows.Forms.Label lblBestBidPriceVal;
        private System.Windows.Forms.Label lblBestAskPrice;
        private System.Windows.Forms.Label lblBestAskPriceVal;
        private System.Windows.Forms.Label lblTotalQuatityTraded;
        private System.Windows.Forms.Label lblTotalQuatityTradedVal;
    }
}

