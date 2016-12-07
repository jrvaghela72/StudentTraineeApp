namespace FileStorageApp
{
    partial class BarGraph
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
            this.bChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtType = new MetroFramework.Controls.MetroComboBox();
            this.chrUpdate = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.bChart)).BeginInit();
            this.SuspendLayout();
            // 
            // bChart
            // 
            this.bChart.BorderlineWidth = 0;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle;
            chartArea1.AxisY.Interval = 5D;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.LabelStyle.Interval = 5D;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY.MaximumAutoSize = 100F;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.bChart.ChartAreas.Add(chartArea1);
            this.bChart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.Name = "Legend1";
            this.bChart.Legends.Add(legend1);
            this.bChart.Location = new System.Drawing.Point(3, 55);
            this.bChart.Name = "bChart";
            this.bChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Student Name";
            series1.ToolTip = "#VALX #VAL%";
            this.bChart.Series.Add(series1);
            this.bChart.Size = new System.Drawing.Size(722, 408);
            this.bChart.TabIndex = 0;
            this.bChart.Text = "Student Percentage";
            // 
            // chrtType
            // 
            this.chrtType.FormattingEnabled = true;
            this.chrtType.ItemHeight = 23;
            this.chrtType.Items.AddRange(new object[] {
            "Pie",
            "Bar",
            "Column",
            "Spline",
            "Area",
            "Stack"});
            this.chrtType.Location = new System.Drawing.Point(67, 3);
            this.chrtType.Name = "chrtType";
            this.chrtType.PromptText = "Select Chart";
            this.chrtType.Size = new System.Drawing.Size(234, 29);
            this.chrtType.TabIndex = 1;
            this.chrtType.UseSelectable = true;
            this.chrtType.SelectedIndexChanged += new System.EventHandler(this.chrtType_SelectedIndexChanged);
            // 
            // chrUpdate
            // 
            this.chrUpdate.Location = new System.Drawing.Point(307, 3);
            this.chrUpdate.Name = "chrUpdate";
            this.chrUpdate.Size = new System.Drawing.Size(115, 29);
            this.chrUpdate.TabIndex = 2;
            this.chrUpdate.Text = "Update Chart";
            this.chrUpdate.UseSelectable = true;
            this.chrUpdate.Click += new System.EventHandler(this.chrUpdate_Click);
            // 
            // GraphMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chrUpdate);
            this.Controls.Add(this.chrtType);
            this.Controls.Add(this.bChart);
            this.Name = "GraphMain";
            this.Size = new System.Drawing.Size(728, 463);
            this.Load += new System.EventHandler(this.GraphMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox chrtType;
        private MetroFramework.Controls.MetroButton chrUpdate;
        public System.Windows.Forms.DataVisualization.Charting.Chart bChart;
    }
}
