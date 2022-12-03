using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace QL_CK
{
    public partial class ReChart : Form
    {
        public ReChart()
        {
            InitializeComponent();
        }

        Func<ChartPoint, string> labelPoint = chartpoint => String.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);

        private void ReChart_Load(object sender, EventArgs e)
        {
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                SeriesCollection series = new SeriesCollection();
                foreach (var obj in dataSet1.Revenue)
                    series.Add(new PieSeries() { Title = obj.Year.ToString(), Values = new ChartValues<int> { obj.Total }, DataLabels = true, LabelPoint = labelPoint });
                pieChart1.Series = series;
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ADMENU ad = new ADMENU();
            ad.Show();
            this.Hide();
        }

        
    }
}
