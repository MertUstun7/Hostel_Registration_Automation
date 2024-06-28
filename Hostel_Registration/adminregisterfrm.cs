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
    public partial class adminregisterfrm : Form
    {
        public adminregisterfrm()
        {
            InitializeComponent();
        }

        SqlConnection connection=new SqlConnection("Data Source=DESKTOP-DMEJP7U\\SQLEXPRESS;Initial Catalog=tarco_pansiyon;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox2.Text == textBox3.Text)
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("insert into Admins (UserName,Password) values('" + textBox1.Text + "','" + textBox2.Text + "')",connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registration was created succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();

                this.Close();

            }
            else
            {

                MessageBox.Show("Passwords don't match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
