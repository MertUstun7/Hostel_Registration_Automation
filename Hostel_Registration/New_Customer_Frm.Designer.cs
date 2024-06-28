namespace Pansiyon_Kayit_Uygulamasi
{
    partial class New_Customer_Frm
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            label11 = new Label();
            comboBox1 = new ComboBox();
            label10 = new Label();
            txtroomcharge = new TextBox();
            txtroomno = new TextBox();
            btnsave = new Button();
            date_out = new DateTimePicker();
            date_entry = new DateTimePicker();
            txtphoneno = new MaskedTextBox();
            txtsurname = new TextBox();
            txtmail = new TextBox();
            txtidentity = new TextBox();
            txtname = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnoda12 = new Button();
            btnempty = new Button();
            btnoda9 = new Button();
            btnoda11 = new Button();
            btnfull = new Button();
            btnoda8 = new Button();
            btnoda3 = new Button();
            btnoda4 = new Button();
            btnoda10 = new Button();
            btnoda7 = new Button();
            btnoda6 = new Button();
            btnoda5 = new Button();
            btnoda2 = new Button();
            btnoda1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtroomcharge);
            groupBox1.Controls.Add(txtroomno);
            groupBox1.Controls.Add(btnsave);
            groupBox1.Controls.Add(date_out);
            groupBox1.Controls.Add(date_entry);
            groupBox1.Controls.Add(txtphoneno);
            groupBox1.Controls.Add(txtsurname);
            groupBox1.Controls.Add(txtmail);
            groupBox1.Controls.Add(txtidentity);
            groupBox1.Controls.Add(txtname);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(577, 560);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(455, 487);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 31;
            label11.Text = "0";
            label11.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Info;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "-", "Man", "Woman", "I dont want to specify" });
            comboBox1.Location = new Point(179, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 28);
            comboBox1.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label10.Location = new Point(116, 146);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 29;
            label10.Text = "Gender:";
            // 
            // txtroomcharge
            // 
            txtroomcharge.BackColor = SystemColors.Info;
            txtroomcharge.Enabled = false;
            txtroomcharge.Location = new Point(179, 366);
            txtroomcharge.Name = "txtroomcharge";
            txtroomcharge.ReadOnly = true;
            txtroomcharge.Size = new Size(100, 27);
            txtroomcharge.TabIndex = 7;
            // 
            // txtroomno
            // 
            txtroomno.BackColor = SystemColors.Info;
            txtroomno.Enabled = false;
            txtroomno.Location = new Point(179, 316);
            txtroomno.Name = "txtroomno";
            txtroomno.Size = new Size(100, 27);
            txtroomno.TabIndex = 6;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(258, 502);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(150, 50);
            btnsave.TabIndex = 10;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // date_out
            // 
            date_out.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            date_out.Location = new Point(179, 449);
            date_out.Name = "date_out";
            date_out.Size = new Size(229, 27);
            date_out.TabIndex = 9;
            date_out.ValueChanged += date_out_ValueChanged;
            // 
            // date_entry
            // 
            date_entry.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            date_entry.Location = new Point(179, 405);
            date_entry.Name = "date_entry";
            date_entry.Size = new Size(229, 27);
            date_entry.TabIndex = 8;
            date_entry.ValueChanged += date_entry_ValueChanged;
            // 
            // txtphoneno
            // 
            txtphoneno.BackColor = SystemColors.Info;
            txtphoneno.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtphoneno.Location = new Point(180, 265);
            txtphoneno.Mask = "(999) 000-0000";
            txtphoneno.Name = "txtphoneno";
            txtphoneno.Size = new Size(147, 27);
            txtphoneno.TabIndex = 5;
            // 
            // txtsurname
            // 
            txtsurname.BackColor = SystemColors.Info;
            txtsurname.Location = new Point(180, 100);
            txtsurname.Name = "txtsurname";
            txtsurname.Size = new Size(229, 27);
            txtsurname.TabIndex = 1;
            // 
            // txtmail
            // 
            txtmail.BackColor = SystemColors.Info;
            txtmail.Location = new Point(180, 174);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(229, 27);
            txtmail.TabIndex = 3;
            // 
            // txtidentity
            // 
            txtidentity.BackColor = SystemColors.Info;
            txtidentity.Location = new Point(180, 219);
            txtidentity.MaxLength = 11;
            txtidentity.Name = "txtidentity";
            txtidentity.Size = new Size(229, 27);
            txtidentity.TabIndex = 4;
            // 
            // txtname
            // 
            txtname.BackColor = SystemColors.Info;
            txtname.Location = new Point(180, 54);
            txtname.Name = "txtname";
            txtname.Size = new Size(229, 27);
            txtname.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.Location = new Point(5, 449);
            label7.Name = "label7";
            label7.Size = new Size(177, 20);
            label7.TabIndex = 10;
            label7.Text = "Date Out Of  The Room:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.Location = new Point(72, 405);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 11;
            label6.Text = "Date Of Entry:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.Location = new Point(30, 222);
            label5.Name = "label5";
            label5.Size = new Size(156, 20);
            label5.TabIndex = 12;
            label5.Text = "T.C Identity Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(133, 177);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 13;
            label4.Text = "Mail:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.Location = new Point(97, 268);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 14;
            label8.Text = "Phone No:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.Location = new Point(97, 319);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 14;
            label9.Text = "Room No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(70, 366);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 14;
            label3.Text = "Room Charge:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(104, 107);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 15;
            label2.Text = "Surname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(122, 61);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 16;
            label1.Text = "Name:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 255, 128);
            groupBox2.Controls.Add(btnoda12);
            groupBox2.Controls.Add(btnempty);
            groupBox2.Controls.Add(btnoda9);
            groupBox2.Controls.Add(btnoda11);
            groupBox2.Controls.Add(btnfull);
            groupBox2.Controls.Add(btnoda8);
            groupBox2.Controls.Add(btnoda3);
            groupBox2.Controls.Add(btnoda4);
            groupBox2.Controls.Add(btnoda10);
            groupBox2.Controls.Add(btnoda7);
            groupBox2.Controls.Add(btnoda6);
            groupBox2.Controls.Add(btnoda5);
            groupBox2.Controls.Add(btnoda2);
            groupBox2.Controls.Add(btnoda1);
            groupBox2.Location = new Point(584, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(477, 560);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rooms";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnoda12
            // 
            btnoda12.BackColor = Color.FromArgb(0, 192, 0);
            btnoda12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnoda12.Location = new Point(354, 360);
            btnoda12.Name = "btnoda12";
            btnoda12.Size = new Size(75, 50);
            btnoda12.TabIndex = 11;
            btnoda12.Text = "12";
            btnoda12.UseVisualStyleBackColor = false;
            // 
            // btnempty
            // 
            btnempty.BackColor = Color.FromArgb(0, 192, 0);
            btnempty.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnempty.Location = new Point(269, 472);
            btnempty.Name = "btnempty";
            btnempty.Size = new Size(75, 50);
            btnempty.TabIndex = 13;
            btnempty.Text = "EMPTY";
            btnempty.UseVisualStyleBackColor = false;
            btnempty.Click += btnempty_Click;
            // 
            // btnoda9
            // 
            btnoda9.BackColor = Color.FromArgb(0, 192, 0);
            btnoda9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnoda9.Location = new Point(355, 245);
            btnoda9.Name = "btnoda9";
            btnoda9.Size = new Size(75, 50);
            btnoda9.TabIndex = 8;
            btnoda9.Text = "9";
            btnoda9.UseVisualStyleBackColor = false;
            // 
            // btnoda11
            // 
            btnoda11.BackColor = Color.FromArgb(0, 192, 0);
            btnoda11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnoda11.Location = new Point(180, 355);
            btnoda11.Name = "btnoda11";
            btnoda11.Size = new Size(75, 55);
            btnoda11.TabIndex = 10;
            btnoda11.Text = "11";
            btnoda11.UseVisualStyleBackColor = false;
            // 
            // btnfull
            // 
            btnfull.BackColor = Color.Red;
            btnfull.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnfull.Location = new Point(90, 467);
            btnfull.Name = "btnfull";
            btnfull.Size = new Size(75, 55);
            btnfull.TabIndex = 12;
            btnfull.Text = "FULL";
            btnfull.UseVisualStyleBackColor = false;
            btnfull.Click += button12_Click;
            // 
            // btnoda8
            // 
            btnoda8.BackColor = Color.FromArgb(0, 192, 0);
            btnoda8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnoda8.Location = new Point(181, 240);
            btnoda8.Name = "btnoda8";
            btnoda8.Size = new Size(75, 55);
            btnoda8.TabIndex = 7;
            btnoda8.Text = "8";
            btnoda8.UseVisualStyleBackColor = false;
            // 
            // btnoda3
            // 
            btnoda3.BackColor = Color.FromArgb(0, 192, 0);
            btnoda3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnoda3.Location = new Point(355, 29);
            btnoda3.Name = "btnoda3";
            btnoda3.Size = new Size(75, 52);
            btnoda3.TabIndex = 2;
            btnoda3.Text = "3";
            btnoda3.UseVisualStyleBackColor = false;
            // 
            // btnoda4
            // 
            btnoda4.BackColor = Color.FromArgb(0, 192, 0);
            btnoda4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnoda4.Location = new Point(11, 139);
            btnoda4.Name = "btnoda4";
            btnoda4.Size = new Size(74, 52);
            btnoda4.TabIndex = 3;
            btnoda4.Text = "4";
            btnoda4.UseVisualStyleBackColor = false;
            btnoda4.Click += button7_Click;
            // 
            // btnoda10
            // 
            btnoda10.BackColor = Color.FromArgb(0, 192, 0);
            btnoda10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnoda10.Location = new Point(11, 358);
            btnoda10.Name = "btnoda10";
            btnoda10.Size = new Size(75, 52);
            btnoda10.TabIndex = 9;
            btnoda10.Text = "10";
            btnoda10.UseVisualStyleBackColor = false;
            // 
            // btnoda7
            // 
            btnoda7.BackColor = Color.FromArgb(0, 192, 0);
            btnoda7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnoda7.Location = new Point(11, 243);
            btnoda7.Name = "btnoda7";
            btnoda7.Size = new Size(75, 52);
            btnoda7.TabIndex = 6;
            btnoda7.Text = "7";
            btnoda7.UseVisualStyleBackColor = false;
            // 
            // btnoda6
            // 
            btnoda6.BackColor = Color.FromArgb(0, 192, 0);
            btnoda6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnoda6.Location = new Point(356, 139);
            btnoda6.Name = "btnoda6";
            btnoda6.Size = new Size(74, 52);
            btnoda6.TabIndex = 5;
            btnoda6.Text = "6";
            btnoda6.UseVisualStyleBackColor = false;
            // 
            // btnoda5
            // 
            btnoda5.BackColor = Color.FromArgb(0, 192, 0);
            btnoda5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnoda5.Location = new Point(180, 139);
            btnoda5.Name = "btnoda5";
            btnoda5.Size = new Size(75, 52);
            btnoda5.TabIndex = 4;
            btnoda5.Text = "5";
            btnoda5.UseVisualStyleBackColor = false;
            // 
            // btnoda2
            // 
            btnoda2.BackColor = Color.FromArgb(0, 192, 0);
            btnoda2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnoda2.Location = new Point(181, 29);
            btnoda2.Name = "btnoda2";
            btnoda2.Size = new Size(74, 52);
            btnoda2.TabIndex = 1;
            btnoda2.Text = "2";
            btnoda2.UseVisualStyleBackColor = false;
            // 
            // btnoda1
            // 
            btnoda1.BackColor = Color.FromArgb(0, 192, 0);
            btnoda1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnoda1.Location = new Point(11, 29);
            btnoda1.Name = "btnoda1";
            btnoda1.Size = new Size(74, 52);
            btnoda1.TabIndex = 0;
            btnoda1.Text = "1";
            btnoda1.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // New_Customer_Frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Cyan;
            ClientSize = new Size(1073, 584);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "New_Customer_Frm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Customer";
            Load += YeniMusteriFrm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnsave;
        private DateTimePicker date_out;
        private DateTimePicker date_entry;
        private MaskedTextBox txtphoneno;
        private TextBox txtsurname;
        private TextBox txtmail;
        private TextBox txtidentity;
        private TextBox txtname;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnoda1;
        private Button btnoda12;
        private Button btnempty;
        private Button btnoda9;
        private Button btnoda11;
        private Button btnfull;
        private Button btnoda8;
        private Button btnoda3;
        private Button btnoda4;
        private Button btnoda10;
        private Button btnoda7;
        private Button btnoda6;
        private Button btnoda5;
        private Button btnoda2;
        private TextBox txtroomcharge;
        private TextBox txtroomno;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox comboBox1;
        private Label label11;
        private ContextMenuStrip contextMenuStrip1;
    }
}