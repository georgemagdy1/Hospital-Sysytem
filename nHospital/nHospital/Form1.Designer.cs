namespace nHospital
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNametext = new System.Windows.Forms.TextBox();
            this.Passwordtext = new System.Windows.Forms.TextBox();
            this.ErrorUserName = new System.Windows.Forms.Label();
            this.ErrorPassword = new System.Windows.Forms.Label();
            this.erroruserAndPass = new System.Windows.Forms.Label();
            this.Welcomlabel6 = new System.Windows.Forms.Label();
            this.logInBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // userNametext
            // 
            this.userNametext.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.userNametext.Location = new System.Drawing.Point(116, 137);
            this.userNametext.Multiline = true;
            this.userNametext.Name = "userNametext";
            this.userNametext.Size = new System.Drawing.Size(203, 30);
            this.userNametext.TabIndex = 2;
            // 
            // Passwordtext
            // 
            this.Passwordtext.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Passwordtext.Location = new System.Drawing.Point(116, 171);
            this.Passwordtext.Multiline = true;
            this.Passwordtext.Name = "Passwordtext";
            this.Passwordtext.Size = new System.Drawing.Size(203, 30);
            this.Passwordtext.TabIndex = 3;
            // 
            // ErrorUserName
            // 
            this.ErrorUserName.AutoSize = true;
            this.ErrorUserName.BackColor = System.Drawing.Color.Transparent;
            this.ErrorUserName.ForeColor = System.Drawing.Color.Red;
            this.ErrorUserName.Location = new System.Drawing.Point(161, 121);
            this.ErrorUserName.Name = "ErrorUserName";
            this.ErrorUserName.Size = new System.Drawing.Size(88, 13);
            this.ErrorUserName.TabIndex = 4;
            this.ErrorUserName.Text = "Enter User Name";
            this.ErrorUserName.Visible = false;
            // 
            // ErrorPassword
            // 
            this.ErrorPassword.AutoSize = true;
            this.ErrorPassword.BackColor = System.Drawing.Color.Transparent;
            this.ErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.ErrorPassword.Location = new System.Drawing.Point(179, 204);
            this.ErrorPassword.Name = "ErrorPassword";
            this.ErrorPassword.Size = new System.Drawing.Size(82, 13);
            this.ErrorPassword.TabIndex = 5;
            this.ErrorPassword.Text = "Enetr Password";
            this.ErrorPassword.Visible = false;
            // 
            // erroruserAndPass
            // 
            this.erroruserAndPass.AutoSize = true;
            this.erroruserAndPass.BackColor = System.Drawing.Color.Transparent;
            this.erroruserAndPass.ForeColor = System.Drawing.Color.Red;
            this.erroruserAndPass.Location = new System.Drawing.Point(113, 95);
            this.erroruserAndPass.Name = "erroruserAndPass";
            this.erroruserAndPass.Size = new System.Drawing.Size(196, 13);
            this.erroruserAndPass.TabIndex = 6;
            this.erroruserAndPass.Text = "User Name or Password Is NOT Correct";
            this.erroruserAndPass.Visible = false;
            // 
            // Welcomlabel6
            // 
            this.Welcomlabel6.AutoSize = true;
            this.Welcomlabel6.BackColor = System.Drawing.Color.Transparent;
            this.Welcomlabel6.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomlabel6.Location = new System.Drawing.Point(178, 28);
            this.Welcomlabel6.Name = "Welcomlabel6";
            this.Welcomlabel6.Size = new System.Drawing.Size(323, 22);
            this.Welcomlabel6.TabIndex = 7;
            this.Welcomlabel6.Text = "WELCOM TO ALHAYAH HOSPITAL";
            // 
            // logInBtn
            // 
            this.logInBtn.BackColor = System.Drawing.Color.Turquoise;
            this.logInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logInBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBtn.Location = new System.Drawing.Point(125, 220);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(93, 31);
            this.logInBtn.TabIndex = 8;
            this.logInBtn.Text = "Log In";
            this.logInBtn.UseVisualStyleBackColor = false;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.Transparent;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(225, 220);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(93, 31);
            this.registerBtn.TabIndex = 9;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(688, 1);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(50, 31);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::nHospital.Properties.Resources.IMG_20230513_WA0130;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 370);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.Welcomlabel6);
            this.Controls.Add(this.erroruserAndPass);
            this.Controls.Add(this.ErrorPassword);
            this.Controls.Add(this.ErrorUserName);
            this.Controls.Add(this.Passwordtext);
            this.Controls.Add(this.userNametext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNametext;
        private System.Windows.Forms.TextBox Passwordtext;
        private System.Windows.Forms.Label ErrorUserName;
        private System.Windows.Forms.Label ErrorPassword;
        private System.Windows.Forms.Label erroruserAndPass;
        private System.Windows.Forms.Label Welcomlabel6;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

