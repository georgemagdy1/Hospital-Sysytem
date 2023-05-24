namespace nHospital
{
    partial class MainForm
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.FilenametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewExistingStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logtextBox = new System.Windows.Forms.TextBox();
            this.continueBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Welcomlabel6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Tahoma", 8F);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(222, 108);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(54, 13);
            this.errorLabel.TabIndex = 14;
            this.errorLabel.Text = "File Exists";
            this.errorLabel.Visible = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DeleteBtn.Location = new System.Drawing.Point(207, 176);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(93, 31);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Visible = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.Transparent;
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CreateBtn.Location = new System.Drawing.Point(102, 176);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(93, 31);
            this.CreateBtn.TabIndex = 12;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Visible = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // FilenametextBox
            // 
            this.FilenametextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.FilenametextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FilenametextBox.Location = new System.Drawing.Point(123, 123);
            this.FilenametextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FilenametextBox.Name = "FilenametextBox";
            this.FilenametextBox.Size = new System.Drawing.Size(276, 29);
            this.FilenametextBox.TabIndex = 11;
            this.FilenametextBox.TextChanged += new System.EventHandler(this.FilenametextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "File Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.viewExistingStudentsToolStripMenuItem,
            this.searchForStudentToolStripMenuItem});
            this.studentsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Patients";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addNewStudentToolStripMenuItem.Text = "Add new Patients";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // viewExistingStudentsToolStripMenuItem
            // 
            this.viewExistingStudentsToolStripMenuItem.Name = "viewExistingStudentsToolStripMenuItem";
            this.viewExistingStudentsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.viewExistingStudentsToolStripMenuItem.Text = "View all Patients";
            this.viewExistingStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewExistingStudentsToolStripMenuItem_Click);
            // 
            // searchForStudentToolStripMenuItem
            // 
            this.searchForStudentToolStripMenuItem.Name = "searchForStudentToolStripMenuItem";
            this.searchForStudentToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.searchForStudentToolStripMenuItem.Text = "Search for Patients";
            this.searchForStudentToolStripMenuItem.Click += new System.EventHandler(this.searchForStudentToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.staffToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add ";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // logtextBox
            // 
            this.logtextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.logtextBox.Enabled = false;
            this.logtextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.logtextBox.Location = new System.Drawing.Point(11, 47);
            this.logtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.logtextBox.Name = "logtextBox";
            this.logtextBox.Size = new System.Drawing.Size(146, 29);
            this.logtextBox.TabIndex = 40;
            // 
            // continueBtn
            // 
            this.continueBtn.BackColor = System.Drawing.Color.Transparent;
            this.continueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continueBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.continueBtn.Location = new System.Drawing.Point(313, 176);
            this.continueBtn.Margin = new System.Windows.Forms.Padding(2);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(93, 31);
            this.continueBtn.TabIndex = 41;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BackBtn.Location = new System.Drawing.Point(636, 328);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(93, 31);
            this.BackBtn.TabIndex = 42;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Visible = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(690, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(50, 31);
            this.ExitBtn.TabIndex = 43;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Welcomlabel6
            // 
            this.Welcomlabel6.AutoSize = true;
            this.Welcomlabel6.BackColor = System.Drawing.Color.Transparent;
            this.Welcomlabel6.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomlabel6.Location = new System.Drawing.Point(197, 24);
            this.Welcomlabel6.Name = "Welcomlabel6";
            this.Welcomlabel6.Size = new System.Drawing.Size(202, 22);
            this.Welcomlabel6.TabIndex = 51;
            this.Welcomlabel6.Text = "ALHAYAH HOSPITAL";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::nHospital.Properties.Resources.Screenshot_2023_05_13_23_00_36_50_40deb401b9ffe8e1df2f1cc5ba480b12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 370);
            this.Controls.Add(this.Welcomlabel6);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.logtextBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.FilenametextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox FilenametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewExistingStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchForStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox logtextBox;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label Welcomlabel6;
    }
}