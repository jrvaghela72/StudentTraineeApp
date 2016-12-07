using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using Newtonsoft.Json;

namespace FileStorageApp
{
    public partial class BarGraph : MetroUserControl
    {
        public BarGraph()
        {
            InitializeComponent();
        }
        public BarGraph(string flag)
        {
            InitializeComponent();
        }

        private void GraphMain_Load(object sender, EventArgs e)
        {
            bChart.Refresh();
            bChart.ChartAreas[0].AxisY.Maximum = 100;
            bChart.Titles.Add("Student Chart");
            bChart.Series.Clear();
            chrtType.Visible = true;
            StudentPercentageChart();

        }

        public void StudentPercentageChart()
        {
            bChart.Series.Add("Student Name");
            bChart.Series["Student Name"].Points.AddXY("", 0);
            bChart.Series["Student Name"].ToolTip = "#VALX : #VALY%";
            if (chrtType.SelectedItem == "Pie")
            {
                bChart.Series["Student Name"].ChartType = SeriesChartType.Pie;
            }
            else if (chrtType.SelectedItem == "Bar")
            {
                bChart.Series["Student Name"].ChartType = SeriesChartType.Bar;
            }
            else if (chrtType.SelectedItem == "Column")
            {
                bChart.Series["Student Name"].ChartType = SeriesChartType.Column;
            }
            else if (chrtType.SelectedItem == "Spline")
            {
                bChart.Series["Student Name"].ChartType = SeriesChartType.Spline;
            }
            else if (chrtType.SelectedItem == "Area")
            {
                bChart.Series["Student Name"].ChartType = SeriesChartType.Area;
            }
            else if (chrtType.SelectedItem == "Stack")
            {
                bChart.Series["Student Name"].ChartType = SeriesChartType.StackedBar;
            }


            if (File.Exists(MainWindow.FilePath))
            {
                using (StreamReader reader = new StreamReader(MainWindow.FilePath))
                {
                    string json = reader.ReadToEnd();
                    List<StudentProp> readObject = JsonConvert.DeserializeObject<List<StudentProp>>(json);
                    foreach (StudentProp pr in readObject)
                    {
                        bChart.Series["Student Name"].Points.AddXY(pr.Name, pr.Subjects.Percentage);
                    }
                }
            }
        }
        private void chrtType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chrtType.SelectedItem == "Pie")
            {
                bChart.Series["Student Name"].ChartType = SeriesChartType.Pie;
            }
            else if (chrtType.SelectedItem == "Bar")
            {
                bChart.Series["Student Name"].ChartType = SeriesChartType.Bar;
            }
            else if (chrtType.SelectedItem == "Column")
            {
                bChart.Series["Student Name"].ChartType = SeriesChartType.Column;
            }
            else if (chrtType.SelectedItem == "Spline")
            {
                bChart.Series["Student Name"].ChartType = SeriesChartType.Spline;
            }
            else if (chrtType.SelectedItem == "Area")
            {
                bChart.Series["Student Name"].ChartType = SeriesChartType.Area;
            }
            else if (chrtType.SelectedItem == "Stack")
            {
                bChart.Series["Student Name"].ChartType = SeriesChartType.StackedBar;
            }

        }

        private void chrUpdate_Click(object sender, EventArgs e)
        {
            bChart.Series.Clear();
            StudentPercentageChart();
        }
    }
}
