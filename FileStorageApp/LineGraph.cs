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
    public partial class LineGraph : MetroUserControl
    {
        public LineGraph()
        {
            InitializeComponent();
        }

        private void LineGraph_Load(object sender, EventArgs e)
        {
            lnChart.Titles.Add("Student Mark");
            lnChart.Series.Clear();
            ChartData();
        }
        public void ChartData()
        {
            lnChart.Series.Add("Student State");
            lnChart.Series["Student State"].ChartType = SeriesChartType.Line;
            //stChart.Series["Student State"].Points.AddXY(0,0);
            lnChart.Series["Student State"].ToolTip = "#VALX : #VALY";

            if (File.Exists(MainWindow.FilePath))
            {

                using (StreamReader reader = new StreamReader(MainWindow.FilePath))
                {
                    string json = reader.ReadToEnd();
                    List<StudentProp> readObject = JsonConvert.DeserializeObject<List<StudentProp>>(json);
                    foreach (StudentProp pr in readObject)
                    {
                        lnChart.Series["Student State"].SmartLabelStyle.Enabled = true;
                        if (!StudentState.GetState(pr))
                        {
                            lnChart.Series["Student State"].Color = Color.Green;
                        }
                        else
                        {
                            lnChart.Series["Student State"].Color = Color.Red;
                        }
                        lnChart.Series["Student State"].Points.AddXY(pr.Name, pr.Subjects.Total);
                    }
                    
                }
            }
        }

        private void btnUpdt_Click(object sender, EventArgs e)
        {
            lnChart.Series.Clear();
            ChartData();
        }
    }
}
