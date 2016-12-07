using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Newtonsoft.Json;

namespace FileStorageApp
{
    public partial class MainWindow :MetroForm 
    {

        private static MainWindow _instance;
        FileMain m;

        public static String MainPath
        {
            get
            {
                return Path.Combine(Application.StartupPath, "Student");
            }
        }

        public static String FilePath
        {
            get
            {
                return Path.Combine(MainPath, "Main.json");
            }
        }
        
        public static MainWindow Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new MainWindow();
                }
                return _instance;
            }
        }
        
        public MetroPanel MetroContainer
        {
            get
            {
                return mPanel;
            }
            set
            {
                mPanel = value;
            }
        }

        public MetroLink MetroBack
        {
            get
            {
                return mBack;
            }
            set
            {
                mBack = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            m = new FileMain();
            try
            {
                m.CreateMainDirectory(MainPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mBack.Visible = false;
            _instance = this;
            DashBoard dc = new DashBoard();
            dc.Dock = DockStyle.Fill;
            mPanel.Controls.Add(dc); 
        }

        private void mBack_Click(object sender, EventArgs e)
        {
            mPanel.Controls["DashBoard"].BringToFront();
            mBack.Visible = false;
        }
    }
}
