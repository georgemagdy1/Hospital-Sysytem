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
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
                BinaryReader bn = new BinaryReader(File.Open(Info.filename, FileMode.Open, FileAccess.Read));
                int num_of_rec = (int)bn.BaseStream.Length / Info.rec_size;
                if (num_of_rec > 0)
                {
                    try
                    {
                        DisplayBtn.Text = "next";
                        bn.BaseStream.Seek(Info.count, SeekOrigin.Begin);
                        IDtextBox.Text = bn.ReadInt32().ToString();
                        NametextBox.Text = bn.ReadString();
                        TeltextBox.Text = bn.ReadString();
                        YeartextBox.Text = bn.ReadInt32().ToString();
                        GendertextBox.Text = bn.ReadString();
                        IllnesstextBox.Text = bn.ReadString();

                        NumOfRecLabel.Text = ((Info.count / Info.rec_size) + 1).ToString();
                        FileSizeLabel.Text = bn.BaseStream.Length.ToString();
                        if ((Info.count / Info.rec_size) >= num_of_rec - 1)
                        {
                            Info.count = 0;
                            MessageBox.Show("Read From Begining");
                        }
                        else
                        {
                            Info.count += Info.rec_size;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("File Is Empty");

                }

                bn.Close();
            
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            displayFNtextBox.Text = Info.filename;
            logtextBox.Text = "User Name: " + Info.logName;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InsertForm().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void searchForStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchModifyForm().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
