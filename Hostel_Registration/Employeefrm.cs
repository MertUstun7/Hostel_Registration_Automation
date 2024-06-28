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
    public partial class Employeefrm : Form
    {
        public Employeefrm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DMEJP7U\\SQLEXPRESS;Initial Catalog=tarco_pansiyon;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("insert into Employees (Adi,Soyadi,Bolum,Maas) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Succeeded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }

            foreach(Control item in this.Controls)
            {

                if(item is TextBox)
                {
                    TextBox txt = (TextBox)item;

                    txt.Clear();
                }
            }
            
        }
    }
}
