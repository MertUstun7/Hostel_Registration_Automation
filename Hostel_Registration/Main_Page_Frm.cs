using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Kayit_Uygulamasi
{
    public partial class Main_Page_Frm : Form
    {
        public Main_Page_Frm()
        {
            InitializeComponent();
        }

        private void admngrs_Click(object sender, EventArgs e)
        {
            Admin_Login_Frm admin_Login_Frm = new Admin_Login_Frm();
            this.Hide();
            admin_Login_Frm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            New_Customer_Frm yeniMusteriFrm = new New_Customer_Frm();
            yeniMusteriFrm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Roomsfrm roomsfrm = new Roomsfrm();

            roomsfrm.ShowDialog();

        }

        private void Main_Page_Frm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer_List_Frm customer_List_Frm = new Customer_List_Frm();

            customer_List_Frm.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tarçın Hostel Registration Application / 2024-Hatay", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();

            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void Main_Page_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Employeefrm employeefrm = new Employeefrm();

            employeefrm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            income_and_expense_statement iasf = new income_and_expense_statement();

            iasf.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            productbillsfrm prdc = new productbillsfrm();

            prdc.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            radiofrm radiofrm = new radiofrm();

            radiofrm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            change_password_frm change_Password_Frm = new change_password_frm();

            change_Password_Frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            customerMessagesFrm cmf = new customerMessagesFrm();

            cmf.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
