using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace nHospital
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Info.filename = "D:\\" + FilenametextBox.Text + ".txt";
            if (!File.Exists(Info.filename))
            {
                File.Create(Info.filename).Close();
                MessageBox.Show("file is created");

            }
            else
            {
                errorLabel.Visible = true;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string p = "D:\\" + FilenametextBox.Text + ".txt";
            if (File.Exists(p))
            {
                File.Delete(p);
                MessageBox.Show("File Is Deleted");
                FilenametextBox.Clear();

            }
            else
            {
                MessageBox.Show("File not exist");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBtn.Visible = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBtn.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FilenametextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InsertForm().Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            logtextBox.Text = "User Name: " + Info.logName;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
             if (FilenametextBox.Text == "")
            {
                MessageBox.Show("Write The File Name");
            }
            else
            {
                Info.filename = "D:\\" + FilenametextBox.Text + ".txt";
                if (File.Exists(Info.filename))
                {
                    this.Hide();
                    new InsertForm().Show();
                }
                else
                {
                    MessageBox.Show("File NOT Exist");
                }
            }
        }

        private void viewExistingStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DisplayForm().Show();
        }

        private void searchForStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchModifyForm().Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




    }
}

