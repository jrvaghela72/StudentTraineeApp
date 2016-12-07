namespace FileStorageApp
{
    partial class LineGraph
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lnChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnUpdt = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.lnChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lnChart
            // 
            this.lnChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.lnChart.BorderSkin.BorderWidth = 0;
            chartArea1.Area3DStyle.Inclination = 10;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea1.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Title = "Student Name";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Maroon;
            chartArea1.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisY.LabelStyle.Interval = 50D;
            chartArea1.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MaximumAutoSize = 100F;
            chartArea1.AxisY.Title = "Total Mark";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Maroon;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.lnChart.ChartAreas.Add(chartArea1);
            this.lnChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.lnChart.Legends.Add(legend1);
            this.lnChart.Location = new System.Drawing.Point(0, 71);
            this.lnChart.Name = "lnChart";
            this.lnChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Mark";
            series1.ToolTip = "#VALX #VAL";
            this.lnChart.Series.Add(series1);
            this.lnChart.Size = new System.Drawing.Size(728, 392);
            this.lnChart.TabIndex = 1;
            this.lnChart.Text = "Student Total Mark";
            // 
            // btnUpdt
            // 
            this.btnUpdt.Location = new System.Drawing.Point(615, 3);
            this.btnUpdt.Name = "btnUpdt";
            this.btnUpdt.Size = new System.Drawing.Size(110, 40);
            this.btnUpdt.TabIndex = 2;
            this.btnUpdt.Text = "Update Chart";
            this.btnUpdt.UseSelectable = true;
            this.btnUpdt.Click += new System.EventHandler(this.btnUpdt_Click);
            // 
            // LineGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdt);
            this.Controls.Add(this.lnChart);
            this.Name = "LineGraph";
            this.Size = new System.Drawing.Size(728, 463);
            this.Load += new System.EventHandler(this.LineGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lnChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart lnChart;
        private MetroFramework.Controls.MetroButton btnUpdt;
    }
}
