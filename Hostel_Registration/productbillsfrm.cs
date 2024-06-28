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
    public partial class productbillsfrm : Form
    {
        public productbillsfrm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DMEJP7U\\SQLEXPRESS;Initial Catalog=tarco_pansiyon;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        private void button1_Click(object sender, EventArgs e)
        {

            connection.Open();

            try
            {
                DialogResult result = MessageBox.Show("Are you sure ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {

                    textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();


                    SqlCommand command = new SqlCommand("insert into UrunveFatura (Urun,Fatura) values ('"+textBox1.Text+"','"+textBox2.Text+"')",connection);    

                    command.ExecuteNonQuery();

                    connection.Close();



                }
            }
            catch (Exception msg)
            {

                MessageBox.Show(msg.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                connection.Close();
            }

        }

        private void productbillsfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
