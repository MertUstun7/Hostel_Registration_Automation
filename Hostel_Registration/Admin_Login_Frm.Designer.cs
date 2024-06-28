namespace Pansiyon_Kayit_Uygulamasi
{
    partial class Admin_Login_Frm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login_Frm));
            label1 = new Label();
            label2 = new Label();
            txtuser = new TextBox();
            txtpassword = new TextBox();
            btnlogin = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(24, 106);
            label1.Name = "label1";
            label1.Size = new Size(47, 21);
            label1.TabIndex = 0;
            label1.Text = "User:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(3, 153);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(93, 104);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(179, 27);
            txtuser.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(93, 151);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(179, 27);
            txtpassword.TabIndex = 3;
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnlogin.Location = new Point(289, 196);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(156, 45);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Log In";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(310, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(9, 48);
            label3.Name = "label3";
            label3.Size = new Size(231, 18);
            label3.TabIndex = 6;
            label3.Text = "Welcome to Tarçın Hostel";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(99, 196);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(141, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create a new admin";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Admin_Login_Frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 128, 0);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(494, 269);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(txtuser);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Admin_Login_Frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Login";
            FormClosed += Admin_Login_Frm_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtuser;
        private TextBox txtpassword;
        private Button btnlogin;
        private PictureBox pictureBox1;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}
