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

namespace дз11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            Chart chart1 = new Chart();
            chart1.ChartAreas.Add("chartArea1");

            chart1.Series.Add("series1");
            chart1.Series["series1"].ChartType = SeriesChartType.Column;
           
            chart1.Series["series1"].Points.AddXY("A", 10);
            chart1.Series["series1"].Points.AddXY("B", 20);
            chart1.Series["series1"].Points.AddXY("C", 30);
            chart1.Series["series1"].Color = Color.Red;
         
            chart1.Titles.Add("Chart Title");
            
            chart1.Dock = DockStyle.Fill;
            this.Controls.Add(chart1);
        }
    }
}
