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
using System.IO;
using Newtonsoft.Json;
using MetroFramework;

namespace FileStorageApp
{
    public partial class AddStudent : MetroUserControl
    {
        List<StudentProp> list = null;
        int rollno = 1;
        public AddStudent()
        {
            InitializeComponent();
            list = new List<StudentProp>();
            mRNo.Text = rollno.ToString();
        }

        private void mBtn_Click(object sender, EventArgs e)
        {
            Boolean isUserExist = false;
            if (File.Exists(MainWindow.FilePath))
            {
                using (StreamReader reader = new StreamReader(MainWindow.FilePath))
                {
                    string json = reader.ReadToEnd();
                    List<StudentProp> readObject = JsonConvert.DeserializeObject<List<StudentProp>>(json);
                    foreach (StudentProp pr in readObject)
                    {
                        if (pr.Rollno == rollno)
                        {
                            isUserExist = true;
                        }
                    }
                }
            }


            if (isUserExist == false)
            {
                String name = mName.Text;
                String cls = mClass.Text;
                String sem = mSem.Text;
                int adbms; if (!int.TryParse(mAdbms.Text, out adbms)) { MetroMessageBox.Show(this, "ADBMS mark in not valid format"); }
                int ns; if (!int.TryParse(mNs.Text, out ns)) { MetroMessageBox.Show(this, "NS mark in not valid format"); }
                int mc; if (!int.TryParse(mMc.Text, out mc)) { MetroMessageBox.Show(this, "MC mark in not valid format"); }
                int an; if (!int.TryParse(mAn.Text, out an)) { MetroMessageBox.Show(this, "AN mark in not valid format"); }
                int se; if (!int.TryParse(mSe.Text, out se)) { MetroMessageBox.Show(this, "SE mark in not valid format"); }

                StudentProp data = new StudentProp();
                data.Rollno = rollno;
                data.Name = name;
                data.Cls = cls;
                data.Sem = sem;
                data.Subjects = new SubProp()
                {
                    Adbms = adbms,
                    An = an,
                    Mc = mc,
                    Ns = ns,
                    Se=se,
                    Total=(adbms+an+mc+ns+se),
                    Percentage= (adbms + an + mc + ns + se)/5
                };
                list.Add(data);
                File.WriteAllText(MainWindow.FilePath, JsonConvert.SerializeObject(list));
                ResetValue();
                rollno++;
                mRNo.Text = rollno.ToString();
            }
            else
            {
                MetroMessageBox.Show(this, "User already exist with this roll number!");
            }
        }

        private void rstBtn_Click(object sender, EventArgs e)
        {
            ResetValue();
        }
        public void ResetValue()
        {
            mName.Text = String.Empty;
            mClass.Text = String.Empty;
            mSem.Text = String.Empty;
            mAdbms.Text = String.Empty;
            mNs.Text = String.Empty;
            mSe.Text = String.Empty;
            mMc.Text = String.Empty;
            mAn.Text = String.Empty;
        }
        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
