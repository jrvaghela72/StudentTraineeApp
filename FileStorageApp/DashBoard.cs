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

namespace FileStorageApp
{
    public partial class DashBoard : MetroUserControl
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void mAdd_Click(object sender, EventArgs e)
        {
            if (!MainWindow.Instance.Controls.ContainsKey("AddStudent"))
            {
                AddStudent uc = new AddStudent();
                uc.Dock = DockStyle.Fill;
                MainWindow.Instance.MetroContainer.Controls.Add(uc);
            }
            MainWindow.Instance.MetroContainer.Controls["AddStudent"].BringToFront();
            MainWindow.Instance.MetroBack.Visible = true;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (!MainWindow.Instance.Controls.ContainsKey("GraphMain"))
            {
                BarGraph uc = new BarGraph();
                uc.Dock = DockStyle.Fill;
                MainWindow.Instance.MetroContainer.Controls.Add(uc);
            }
            MainWindow.Instance.MetroContainer.Controls["GraphMain"].BringToFront();
            MainWindow.Instance.MetroBack.Visible = true;
        }

        private void mSGraph_Click(object sender, EventArgs e)
        {
            if (!MainWindow.Instance.Controls.ContainsKey("SecondGraph"))
            {
                StateGraph uc = new StateGraph();
                uc.Dock = DockStyle.Fill;
                MainWindow.Instance.MetroContainer.Controls.Add(uc);
            }
            MainWindow.Instance.MetroContainer.Controls["SecondGraph"].BringToFront();
            MainWindow.Instance.MetroBack.Visible = true;
        }

        private void crtLine_Click(object sender, EventArgs e)
        {

            if (!MainWindow.Instance.Controls.ContainsKey("LineGraph"))
            {
                LineGraph uc = new LineGraph();
                uc.Dock = DockStyle.Fill;
                MainWindow.Instance.MetroContainer.Controls.Add(uc);
            }
            MainWindow.Instance.MetroContainer.Controls["LineGraph"].BringToFront();
            MainWindow.Instance.MetroBack.Visible = true;
        }

        private void stdUpdate_Click(object sender, EventArgs e)
        {
            if (!MainWindow.Instance.Controls.ContainsKey("UpdateStudent"))
            {
                UpdateStudent uc = new UpdateStudent();
                uc.Dock = DockStyle.Fill;
                MainWindow.Instance.MetroContainer.Controls.Add(uc);
            }
            MainWindow.Instance.MetroContainer.Controls["UpdateStudent"].BringToFront();
            MainWindow.Instance.MetroBack.Visible = true;
        }
    }
}
