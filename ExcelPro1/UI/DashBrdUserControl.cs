using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using ExcelPro1.Model;

namespace ExcelPro1
{
    public partial class DashBrdUserControl : UserControl
    {
        Chart piePnLChart;
        Chart pieCustChart;
        Chart pieItemChart;
        //Chart barChart;

        DBStrategy dbStrategy;

        public DashBrdUserControl(DBStrategy _dbStrategy)
        {
            InitializeComponent();

            //dbStrategy = new SqliteDBStrategy();
            dbStrategy = _dbStrategy;

            InitializeChart();
        }

        private void InitializeChart()
        {
            this.components = new System.ComponentModel.Container();

            ChartArea chartArea1 = new ChartArea();

            Legend legend1 = new Legend()
            { BackColor = Color.Transparent, ForeColor = Color.Black, Title = "Revenue"};

            Legend legend2 = new Legend()
            { BackColor = Color.Transparent, ForeColor = Color.Black, Title = "Orders" };

            Legend legend3 = new Legend()
            { BackColor = Color.Transparent, ForeColor = Color.Black, Title = "Sales" };



            piePnLChart = new Chart();
            pieCustChart = new Chart();
            pieItemChart = new Chart();

            //barChart = new Chart();

            ((ISupportInitialize)(piePnLChart)).BeginInit();
            ((ISupportInitialize)(pieCustChart)).BeginInit();
            ((ISupportInitialize)(pieItemChart)).BeginInit();
            //((ISupportInitialize)(barChart)).BeginInit();

            SuspendLayout();

            //===Pie PnL chart
            chartArea1.Name = "piePnLChartArea";
            piePnLChart.ChartAreas.Add(chartArea1);
            piePnLChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            legend1.Docking = Docking.Bottom;
            piePnLChart.Legends.Add(legend1);
            //piePnLChart.Location = new System.Drawing.Point(0, 50);

            //===Pie Customer chart
            chartArea1 = new ChartArea();
            chartArea1.Name = "pieCustomerChartArea";
            pieCustChart.ChartAreas.Add(chartArea1);
            pieCustChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend2";
            legend2.Docking = Docking.Bottom;
            pieCustChart.Legends.Add(legend2);
            pieCustChart.Location = new System.Drawing.Point(0, 50);


            //===Pie Item chart
            chartArea1 = new ChartArea();
            chartArea1.Name = "pieItemChartArea";
            pieItemChart.ChartAreas.Add(chartArea1);
            pieItemChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend3";
            legend3.Docking = Docking.Bottom;
            pieItemChart.Legends.Add(legend3);
            pieItemChart.Location = new System.Drawing.Point(0, 50);

            ////====Bar Chart
            //chartArea1 = new ChartArea();
            //chartArea1.Name = "BarChartArea";
            //barChart.ChartAreas.Add(chartArea1);
            //barChart.Dock = System.Windows.Forms.DockStyle.Fill;
            //legend2.Name = "Legend3";
            //barChart.Legends.Add(legend2);

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(284, 262);           
            //this.Load += new EventHandler(Form1_Load);
            ((ISupportInitialize)(this.piePnLChart)).EndInit();
            //((ISupportInitialize)(this.barChart)).EndInit();
            ((ISupportInitialize)(this.pieCustChart)).EndInit();
            ((ISupportInitialize)(this.pieItemChart)).EndInit();
            this.ResumeLayout(false);

            LoadpiePnLChart();
            LoadpieCustomerChart();
            LoadpieItemChart();
            //LoadBarChart();

        }

        void Form1_Load(object sender, EventArgs e)
        {
            //LoadpiePnLChart();
            //LoadBarChart();
        }

        void LoadpiePnLChart()
        {
            piePnLChart.Series.Clear();
            piePnLChart.Palette = ChartColorPalette.Excel;
            piePnLChart.BackColor = Color.WhiteSmoke;
            piePnLChart.Titles.Add(new Title(
                                                "Profit & Loss",
                                                Docking.Top,
                                                new Font("Calibri", 18f, FontStyle.Bold),
                                                Color.CornflowerBlue
                                            ));
            piePnLChart.ChartAreas[0].BackColor = Color.Transparent;

            Series series1 = new Series
            {
                Name = "series1",
                IsVisibleInLegend = true,
                Color = System.Drawing.Color.AliceBlue,
                ChartType = SeriesChartType.Pie
            };

            piePnLChart.Series.Add(series1);

            Account[] arr_Account = new Account[4];

            // fetch DB Values
            dbStrategy.getPnL(ref arr_Account);

            int i = 0;
            foreach (Account acc in arr_Account)
            {
                if (acc.AcName == null)
                    continue;

                series1.Points.Add(acc.Revenue);

                var p1 = series1.Points[i];

                //p1.AxisLabel = acc.Revenue.ToString();
                p1.Label = "#PERCENT";//"#PERCENT\n#VALX";
                p1.LegendText = acc.AcName;

                i++;
            }

            piePnLChart.Invalidate();
            panel1.Controls.Add(piePnLChart);
        }

        void LoadpieCustomerChart()
        {
            pieCustChart.Series.Clear();
            pieCustChart.Palette = ChartColorPalette.Excel;
            pieCustChart.BackColor = Color.WhiteSmoke;
            pieCustChart.Titles.Add(new Title(
                                                "Top 5 Customers",
                                                Docking.Top,
                                                new Font("Calibri", 18f, FontStyle.Bold),
                                                Color.CornflowerBlue
                                            ));
            pieCustChart.ChartAreas[0].BackColor = Color.Transparent;

            Series series1 = new Series
            {
                Name = "series1",
                IsVisibleInLegend = true,
                Color = System.Drawing.Color.AliceBlue,
                ChartType = SeriesChartType.Pie
            };

            pieCustChart.Series.Add(series1);

            Customer[] arr_Customers = new Customer[5];

            // fetch DB Values
            dbStrategy.getTop5Customer(ref arr_Customers);

            int i = 0;
            foreach (Customer cust in arr_Customers)
            {
                if (cust.CustName == null)
                    continue;

                series1.Points.Add(cust.Order);

                var p1 = series1.Points[i];

                //p1.AxisLabel = acc.Revenue.ToString();
                p1.Label = "#PERCENT";
                p1.LegendText = cust.CustName;

                i++;
            }

            pieCustChart.Invalidate();
            panel2.Controls.Add(pieCustChart);
        }

        void LoadpieItemChart()
        {
            pieItemChart.Series.Clear();
            pieItemChart.Palette = ChartColorPalette.Excel;
            pieItemChart.BackColor = Color.WhiteSmoke;
            pieItemChart.Titles.Add(new Title(
                                                "Top 5 Items",
                                                Docking.Top,
                                                new Font("Calibri", 18f, FontStyle.Bold),
                                                Color.CornflowerBlue
                                            ));
            pieItemChart.ChartAreas[0].BackColor = Color.Transparent;

            Series series1 = new Series
            {
                Name = "series1",
                IsVisibleInLegend = true,
                Color = System.Drawing.Color.AliceBlue,
                ChartType = SeriesChartType.Pie
            };

            pieItemChart.Series.Add(series1);

            Items[] arr_Items = new Items[5];

            // fetch DB Values
            dbStrategy.getTop5Items(ref arr_Items);

            int i = 0;
            foreach (Items item in arr_Items)
            {
                if (item.ItemName == null)
                    continue;

                series1.Points.Add(item.Sales);

                var p1 = series1.Points[i];

                //p1.AxisLabel = acc.Revenue.ToString();
                p1.Label = "#PERCENT";
                p1.LegendText = item.ItemName;

                i++;
            }

            pieItemChart.Invalidate();
            panel3.Controls.Add(pieItemChart);
        }
        //void LoadBarChart()
        //{
        //    barChart.Series.Clear();
        //    barChart.BackColor = Color.LightYellow;
        //    barChart.Palette = ChartColorPalette.Fire;
        //    barChart.ChartAreas[0].BackColor = Color.Transparent;
        //    barChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        //    barChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        //    Series series = new Series
        //    {
        //        Name = "series2",
        //        IsVisibleInLegend = false,
        //        ChartType = SeriesChartType.Column
        //    };
        //    barChart.Series.Add(series);
        //    series.Points.Add(70000);
        //    var p1 = series.Points[0];
        //    p1.Color = Color.Red;
        //    p1.AxisLabel = "Hiren Khirsaria";
        //    p1.LegendText = "Hiren Khirsaria";
        //    p1.Label = "70000";

        //    series.Points.Add(30000);
        //    var p2 = series.Points[1];
        //    p2.Color = Color.Yellow;
        //    p2.AxisLabel = "ABC XYZ";
        //    p2.LegendText = "ABC XYZ";
        //    p2.Label = "30000";
        //    barChart.Invalidate();

        //    panel2.Controls.Add(barChart);
        //}

    }
}
