using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace nHospital
{
    public partial class Form1 : Form
    {
        private const string passwords = "D:\\passwords.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            string username = userNametext.Text;
            string password = Passwordtext.Text;
            ErrorPassword.Visible = false;
            ErrorUserName.Visible = false;
            erroruserAndPass.Visible = false;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
                {
                    ErrorUserName.Visible = true;
                    ErrorPassword.Visible = true;
                }

                else if (string.IsNullOrEmpty(username))
                {
                    ErrorUserName.Visible = true;
                }
                else
                {
                    ErrorPassword.Visible = true;
                }


            }
            else
            {
                // تجزئة كلمة المرور باستخدام SHA256
                string hashedPassword = HashPassword(password);

                // التحقق من صحة بيانات المستخدم
                if (CheckCredentials(username, hashedPassword))
                {
                    // تم تسجيل الدخول بنجاح
                    Info.logName = userNametext.Text;
                    this.Hide();
                    new MainForm().Show();
                    userNametext.Clear();
                    Passwordtext.Clear();
                }
                else
                {
                    // فشل تسجيل الدخول
                    erroruserAndPass.Visible = true;
                    userNametext.Clear();
                    Passwordtext.Clear();
                }
            }
        }


        private bool CheckCredentials(string id, string hashedPassword)
        {
            // قراءة بيانات المستخدم من الملف
            string[] lines = File.ReadAllLines(passwords);

            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (fields.Length == 2 && fields[0] == id && fields[1] == hashedPassword)
                {
                    return true;
                }
            }

            return false;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string username = userNametext.Text;
            string password = Passwordtext.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                // إدخال غير صالح
                return;
            }

            // تجزئة كلمة المرور باستخدام SHA256
            string hashedPassword = HashPassword(password);

            // كتابة بيانات المستخدم إلى الملف
            string credentials = string.Format("{0},{1}", username, hashedPassword);
            File.AppendAllText(passwords, credentials + Environment.NewLine);

            // تم التسجيل بنجاح
            MessageBox.Show("Registration successful!");
            userNametext.Clear();
            Passwordtext.Clear();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



    }
}
