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
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace FileStorageApp
{
    public partial class StateGraph : MetroUserControl
    {      
        public StateGraph()
        {
            InitializeComponent();
        }

        private void SecondGraph_Load(object sender, EventArgs e)
        {
            stChart.Titles.Add("Student State");
            stChart.Series.Clear();
            ChartData();
        }
        public void ChartData()
        {
            stChart.Series.Add("Student State");
            stChart.Series["Student State"].ChartType = SeriesChartType.Pie;
            //stChart.Series["Student State"].Points.AddXY(0,0);
            stChart.Series["Student State"].ToolTip = "#VALX : #VALY";

            if (File.Exists(MainWindow.FilePath))
            {
                
                using (StreamReader reader = new StreamReader(MainWindow.FilePath))
                {
                    int pass = 0;
                    int fail = 0;
                    string json = reader.ReadToEnd();
                    List<StudentProp> readObject = JsonConvert.DeserializeObject<List<StudentProp>>(json);
                    foreach (StudentProp pr in readObject)
                    {
                        if (!StudentState.GetState(pr))
                        {
                            pass++;
                        }else
                        {
                            fail++;
                        }
                    }
                    if (pass!=0)
                    { 
                        stChart.Series["Student State"].Points.AddXY("Pass : "+pass, pass);
                    }
                    if (fail!=0)
                    {
                        stChart.Series["Student State"].Points.AddXY("Fail : "+fail, fail);
                    }
                }
            }
        }

        private void updBtnChrt_Click(object sender, EventArgs e)
        {
            stChart.Series.Clear();
            ChartData();
        }
    }
}
