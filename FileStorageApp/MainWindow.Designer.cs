namespace FileStorageApp
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mBack = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mPanel
            // 
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(24, 64);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(728, 463);
            this.mPanel.TabIndex = 0;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // mBack
            // 
            this.mBack.DisplayFocus = true;
            this.mBack.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mBack.Image = ((System.Drawing.Image)(resources.GetObject("mBack.Image")));
            this.mBack.Location = new System.Drawing.Point(33, 27);
            this.mBack.Name = "mBack";
            this.mBack.Size = new System.Drawing.Size(28, 23);
            this.mBack.TabIndex = 1;
            this.mBack.UseSelectable = true;
            this.mBack.Click += new System.EventHandler(this.mBack_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 550);
            this.Controls.Add(this.mBack);
            this.Controls.Add(this.mPanel);
            this.Name = "MainWindow";
            this.Resizable = false;
            this.Text = "     Student Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroLink mBack;
    }
}

