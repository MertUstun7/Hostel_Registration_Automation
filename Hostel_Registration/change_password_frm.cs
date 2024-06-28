using Microsoft.Data.SqlClient;
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
    public partial class change_password_frm : Form
    {
        public change_password_frm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new("Data Source=DESKTOP-DMEJP7U\\SQLEXPRESS;Initial Catalog=tarco_pansiyon;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                connection.Open();

                SqlCommand command = new SqlCommand("Update Admins Set Password='" + textBox1.Text + "' where UserName='" + textBox3.Text.Trim() + "'", connection);

                command.ExecuteNonQuery();

                MessageBox.Show("Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach(Control item in this.Controls)
                {
                    if(item is TextBox)
                    {
                        TextBox txtbox = (TextBox)item;
                        txtbox.Clear();
                    }
                }

                connection.Close();

            }

            else
            {

                MessageBox.Show("passwords do not match each other", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
