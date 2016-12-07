namespace FileStorageApp
{
    partial class StateGraph
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
            this.stChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.updBtnChrt = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.stChart)).BeginInit();
            this.SuspendLayout();
            // 
            // stChart
            // 
            chartArea1.Name = "ChartArea1";
            this.stChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.stChart.Legends.Add(legend1);
            this.stChart.Location = new System.Drawing.Point(0, 60);
            this.stChart.Name = "stChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Student State";
            series1.ToolTip = "#VALX #VAL";
            this.stChart.Series.Add(series1);
            this.stChart.Size = new System.Drawing.Size(728, 403);
            this.stChart.TabIndex = 0;
            this.stChart.Text = "Student State";
            // 
            // updBtnChrt
            // 
            this.updBtnChrt.Location = new System.Drawing.Point(602, 3);
            this.updBtnChrt.Name = "updBtnChrt";
            this.updBtnChrt.Size = new System.Drawing.Size(113, 33);
            this.updBtnChrt.TabIndex = 1;
            this.updBtnChrt.Text = "Update Chart";
            this.updBtnChrt.UseSelectable = true;
            this.updBtnChrt.Click += new System.EventHandler(this.updBtnChrt_Click);
            // 
            // SecondGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updBtnChrt);
            this.Controls.Add(this.stChart);
            this.Name = "SecondGraph";
            this.Size = new System.Drawing.Size(728, 463);
            this.Load += new System.EventHandler(this.SecondGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart stChart;
        private MetroFramework.Controls.MetroButton updBtnChrt;
    }
}
