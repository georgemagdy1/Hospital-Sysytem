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
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            displayFNtextBox.Text = Info.filename;
            logtextBox.Text = "User Name: "+Info.logName;
        }
        void clear() {
            IDtextBox.Clear(); 
            NametextBox.Clear(); 
            TeltextBox.Clear(); 
            YeartextBox.Clear(); 
            GendertextBox.Text="";
            IllnesstextBox.Clear();
        
        }
        void False()
        {
            errorbierth.Visible = false;
            errorgender.Visible = false;
            errorID.Visible = false;
            errorname.Visible = false;
            errorgender.Visible = false;
            errortel.Visible = false;
            errorillness.Visible = false;
            successfullabel.Visible = false;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            False();
            if (IDtextBox.Text == "" || NametextBox.Text == "" || TeltextBox.Text == "" || YeartextBox.Text == "" || GendertextBox.Text == "" || IllnesstextBox.Text == "")
            {
                if (IDtextBox.Text == "" && NametextBox.Text == "" && TeltextBox.Text == "" && YeartextBox.Text == "" && GendertextBox.Text == "" && IllnesstextBox.Text == "")
                {
                    errorbierth.Visible = true;
                    errorgender.Visible = true;
                    errorID.Visible = true;
                    errorname.Visible = true;
                    errorgender.Visible = true;
                    errortel.Visible = true;
                    errorillness.Visible = true;
                }
                else if (IDtextBox.Text == "")
                {
                    errorID.Visible = true;
                }
                else if (NametextBox.Text == "")
                {
                    errorname.Visible = true;
                }
                else if (TeltextBox.Text == "")
                {
                    errortel.Visible = true;
                }
                else if (YeartextBox.Text == "")
                {
                    errorbierth.Visible = true;
                }
                else if (GendertextBox.Text == "")
                {
                    errorgender.Visible = true;
                }
                else if (IllnesstextBox.Text == "")
                {
                    errorillness.Visible = true;
                }
            }
            else
            {
                if (GendertextBox.Text == "Male")
                {
                    GendertextBox.Text = "M";
                }
                else
                {
                    GendertextBox.Text = "F";
                }
                BinaryWriter bw = new BinaryWriter(File.Open(Info.filename, FileMode.Open, FileAccess.Write));
                int length = (int)bw.BaseStream.Length;
                if (length != 0)
                {
                    bw.BaseStream.Seek(length, SeekOrigin.Begin);
                }
                bw.Write(int.Parse(IDtextBox.Text)); //ID

                NametextBox.Text = NametextBox.Text.PadRight(9); //Name
                bw.Write(NametextBox.Text.Substring(0, 9));

                TeltextBox.Text = TeltextBox.Text.PadRight(11); //Tel 
                bw.Write(TeltextBox.Text.Substring(0, 11));

                bw.Write(int.Parse(YeartextBox.Text)); //Birth Date 

                bw.Write(GendertextBox.Text.Substring(0, 1)); // Gender

                IllnesstextBox.Text = IllnesstextBox.Text.PadRight(9); // Pathlogical Case
                bw.Write(IllnesstextBox.Text.Substring(0, 9));

                clear(); //Clear textBox
                length += Info.rec_size;
                NumOfRecLabel.Text = (length / Info.rec_size).ToString(); // update number of records label
                FileSizeLabel.Text = length.ToString();      //update file length label
                bw.Close();
                successfullabel.Visible = true;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {
            False();

        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
            False();
        }

        private void TeltextBox_TextChanged(object sender, EventArgs e)
        {
            False();
        }

        private void YeartextBox_TextChanged(object sender, EventArgs e)
        {
            False();
        }

        private void GendertextBox_TextChanged(object sender, EventArgs e)
        {
            False();
        }

        private void IllnesstextBox_TextChanged(object sender, EventArgs e)
        {
            False();
        }

        private void searchForStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchModifyForm().Show();
        }

        private void viewExistingStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DisplayForm().Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     


        
    }
}
