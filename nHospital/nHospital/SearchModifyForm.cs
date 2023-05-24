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
    public partial class SearchModifyForm : Form
    {
        public SearchModifyForm()
        {
            InitializeComponent();
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

        private void viewExistingStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DisplayForm().Show();
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

        private void SearchModifyForm_Load(object sender, EventArgs e)
        {
            displayFNtextBox.Text = Info.filename;
            logtextBox.Text = "User Name: " + Info.logName;
        }

        void clear()
        {
            IDtextBox.Clear();
            NametextBox.Clear();
            GendertextBox.Clear();
            TeltextBox.Clear();
            IllnesstextBox.Clear();
            YeartextBox.Clear();
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(Info.filename))
            {
                MessageBox.Show("Please create or open a file first.");
                return;
            }
            String input = IDtextBox.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }
            
            int searchId;
            if (!int.TryParse(input, out searchId))
            {
                
                MessageBox.Show("Please enter a valid integer ID.");
                return;
            }
            BinaryReader reader = new BinaryReader(File.Open(Info.filename, FileMode.Open));
            try
            {
                
                while (reader.PeekChar() > -1)
                {
                    int id = reader.ReadInt32();
                    String name = reader.ReadString();
                    String telephone = reader.ReadString();
                    int age = reader.ReadInt32();
                    String gender = reader.ReadString();
                    String dig = reader.ReadString();
                    if (id == searchId)
                    {

                        IDtextBox.Text = id.ToString(); ;
                        NametextBox.Text = name;
                        TeltextBox.Text = telephone;
                        YeartextBox.Text = age.ToString();
                        GendertextBox.Text = gender;
                        IllnesstextBox.Text = dig;
                        reader.Close();
                        return;
                    }
                }


                
                MessageBox.Show(" ID not found.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            reader.Close();
            
        
        




           /* int flag = 1;
            BinaryReader bn = new BinaryReader(File.Open(Info.filename, FileMode.Open, FileAccess.Read));
            int recoedcount = (int)bn.BaseStream.Length / Info.rec_size;
            for (int i = 0; i < recoedcount; i++)
            {
                try
                {
                    string b = IDtextBox.Text;
                    string name = bn.ReadString();
                    string tel = bn.ReadString();
                    int age = bn.ReadInt32();
                    string gender = bn.ReadString();
                    string illness = bn.ReadString();
                    if (b.ToString() == IDtextBox.Text)
                    {

                        IDtextBox.Text = bn.ReadInt32().ToString();
                        NametextBox.Text = bn.ReadString();
                        TeltextBox.Text = bn.ReadString();
                        YeartextBox.Text = bn.ReadInt32().ToString();
                        GendertextBox.Text = bn.ReadString();
                        IllnesstextBox.Text = bn.ReadString();
                        flag = 2;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            bn.Close();
            if (flag == 1)
            {
                MessageBox.Show("Patient NOT Found");
            }*/
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Info.filename))
            {
                MessageBox.Show("Please create or open a file first.");
                return;
            }

            String input = IDtextBox.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }
            /*int searchId;
            if (!int.TryParse(input, out searchId))
            {
                MessageBox.Show("Please enter a valid integer ID.");
                return;
            } */
            string searchId = IDtextBox.Text;
            BinaryReader reader = new BinaryReader(File.Open(Info.filename, FileMode.Open,FileAccess.Read));
            //BinaryWriter writer = new BinaryWriter(File.Open(Info.filename , FileMode.Create));
             
                bool found = false;
                while (reader.PeekChar() > -1)
                {
                    int id = reader.ReadInt32();
                    String name = reader.ReadString();
                    String telephone = reader.ReadString();
                    int age = reader.ReadInt32();
                    String gender = reader.ReadString();
                    String ill = reader.ReadString();

                    if (id == int .Parse( searchId))
                    {
                        
                        found = true;
                        break;
                    }
                    else
                    {
                        found = false;
                        
                    }

                }
                reader.Close();
                BinaryWriter writer = new BinaryWriter(File.Open(Info.filename, FileMode.Open,FileAccess.Write));
                if (found == true) {


                    //writer.Write(searchId);
                    //writer.Write(IDtextBox.Text.Trim());
                    writer.Write(int.Parse(IDtextBox.Text)); //ID

                    NametextBox.Text = NametextBox.Text.PadRight(9); //Name
                    writer.Write(NametextBox.Text.Substring(0, 9));

                    TeltextBox.Text = TeltextBox.Text.PadRight(11); //Tel 
                    writer.Write(TeltextBox.Text.Substring(0, 11));

                    writer.Write(int.Parse(YeartextBox.Text)); //Birth Date 

                    writer.Write(GendertextBox.Text.Substring(0, 1)); // Gender

                    IllnesstextBox.Text = IllnesstextBox.Text.PadRight(9); // Pathlogical Case
                    writer.Write(IllnesstextBox.Text.Substring(0, 9));
                
                }
                
                else if (found==false)
                {
                    MessageBox.Show("Record not found.");
                    return;
                }
                
                //File.Delete(Info.filename);
                //File.Move(Info.filename , Info.filename);
                writer.Close();
                MessageBox.Show("ID updated successfully");
            
                
           

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
