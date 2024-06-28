namespace Pansiyon_Kayit_Uygulamasi
{
    partial class Customer_List_Frm
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
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            label10 = new Label();
            txtroomcharge = new TextBox();
            txtroomno = new TextBox();
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
            btnupdate = new Button();
            btndelete = new Button();
            btnsearch = new Button();
            label12 = new Label();
            txtsearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 294);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1299, 311);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Info;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "-", "Man", "Woman", "I don't want to specify" });
            comboBox1.Location = new Point(148, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 28);
            comboBox1.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label10.Location = new Point(85, 104);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 49;
            label10.Text = "Gender:";
            // 
            // txtroomcharge
            // 
            txtroomcharge.BackColor = SystemColors.Info;
            txtroomcharge.Enabled = false;
            txtroomcharge.Location = new Point(569, 62);
            txtroomcharge.Name = "txtroomcharge";
            txtroomcharge.ReadOnly = true;
            txtroomcharge.Size = new Size(100, 27);
            txtroomcharge.TabIndex = 7;
            // 
            // txtroomno
            // 
            txtroomno.BackColor = SystemColors.Info;
            txtroomno.Enabled = false;
            txtroomno.Location = new Point(569, 12);
            txtroomno.Name = "txtroomno";
            txtroomno.Size = new Size(100, 27);
            txtroomno.TabIndex = 6;
            // 
            // date_out
            // 
            date_out.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            date_out.Location = new Point(569, 188);
            date_out.Name = "date_out";
            date_out.Size = new Size(229, 27);
            date_out.TabIndex = 39;
            // 
            // date_entry
            // 
            date_entry.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            date_entry.Location = new Point(148, 188);
            date_entry.Name = "date_entry";
            date_entry.Size = new Size(229, 27);
            date_entry.TabIndex = 38;
            // 
            // txtphoneno
            // 
            txtphoneno.BackColor = SystemColors.Info;
            txtphoneno.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtphoneno.Location = new Point(569, 106);
            txtphoneno.Mask = "(999) 000-0000";
            txtphoneno.Name = "txtphoneno";
            txtphoneno.Size = new Size(147, 27);
            txtphoneno.TabIndex = 3;
            // 
            // txtsurname
            // 
            txtsurname.BackColor = SystemColors.Info;
            txtsurname.Location = new Point(149, 58);
            txtsurname.Name = "txtsurname";
            txtsurname.Size = new Size(229, 27);
            txtsurname.TabIndex = 1;
            // 
            // txtmail
            // 
            txtmail.BackColor = SystemColors.Info;
            txtmail.Location = new Point(150, 149);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(229, 27);
            txtmail.TabIndex = 4;
            // 
            // txtidentity
            // 
            txtidentity.BackColor = SystemColors.Info;
            txtidentity.Location = new Point(569, 149);
            txtidentity.Name = "txtidentity";
            txtidentity.Size = new Size(229, 27);
            txtidentity.TabIndex = 5;
            // 
            // txtname
            // 
            txtname.BackColor = SystemColors.Info;
            txtname.Location = new Point(149, 12);
            txtname.Name = "txtname";
            txtname.Size = new Size(229, 27);
            txtname.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.Location = new Point(395, 188);
            label7.Name = "label7";
            label7.Size = new Size(177, 20);
            label7.TabIndex = 40;
            label7.Text = "Date Out Of  The Room:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.Location = new Point(41, 188);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 41;
            label6.Text = "Date Of Entry:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.Location = new Point(419, 152);
            label5.Name = "label5";
            label5.Size = new Size(156, 20);
            label5.TabIndex = 42;
            label5.Text = "T.C Identity Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(103, 152);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 43;
            label4.Text = "Mail:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.Location = new Point(481, 109);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 44;
            label8.Text = "Phone No:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.Location = new Point(487, 15);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 45;
            label9.Text = "Room No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(460, 62);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 46;
            label3.Text = "Room Charge:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(73, 65);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 47;
            label2.Text = "Surname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(91, 19);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 48;
            label1.Text = "Name:";
            // 
            // btnupdate
            // 
            btnupdate.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnupdate.Location = new Point(1173, 15);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(120, 51);
            btnupdate.TabIndex = 50;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndelete
            // 
            btndelete.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btndelete.Location = new Point(1173, 85);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(120, 51);
            btndelete.TabIndex = 51;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnsearch
            // 
            btnsearch.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnsearch.Location = new Point(1224, 204);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(69, 29);
            btnsearch.TabIndex = 52;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label12.Location = new Point(1137, 148);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 54;
            label12.Text = "Name:";
            // 
            // txtsearch
            // 
            txtsearch.BackColor = SystemColors.Info;
            txtsearch.Location = new Point(1137, 171);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(156, 27);
            txtsearch.TabIndex = 55;
            // 
            // Customer_List_Frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Lime;
            ClientSize = new Size(1299, 605);
            Controls.Add(txtsearch);
            Controls.Add(label12);
            Controls.Add(btnsearch);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(comboBox1);
            Controls.Add(label10);
            Controls.Add(txtroomcharge);
            Controls.Add(txtroomno);
            Controls.Add(date_out);
            Controls.Add(date_entry);
            Controls.Add(txtphoneno);
            Controls.Add(txtsurname);
            Controls.Add(txtmail);
            Controls.Add(txtidentity);
            Controls.Add(txtname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Customer_List_Frm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Information of Customer";
            Load += Customer_List_Frm_Load;
            DoubleClick += Customer_List_Frm_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label10;
        private TextBox txtroomcharge;
        private TextBox txtroomno;
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
        private Label label8;
        private Label label9;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnupdate;
        private Button btndelete;
        private Button btnsearch;
        private Label label12;
        private TextBox txtsearch;
    }
}