using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Pansiyon_Kayit_Uygulamasi
{
    public partial class customerMessagesFrm : Form
    {
        public customerMessagesFrm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DMEJP7U\\SQLEXPRESS;Initial Catalog=tarco_pansiyon;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        private void show()
        {

            listView1.Items.Clear();

            connection.Open();

            SqlCommand command = new SqlCommand("select * from CustomerMessages", connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {


                ListViewItem add = new ListViewItem();

                add.Text = reader["mesajid"].ToString();

                add.SubItems.Add(reader["adsoyad"].ToString());

                add.SubItems.Add(reader["mesaj"].ToString());

                listView1.Items.Add(add);
            }

            connection.Close();

        }
        private void customerMessagesFrm_Load(object sender, EventArgs e)
        {
            listView1.Columns[0].Width = 53;
            listView1.Columns[1].Width = 170;
            listView1.Columns[2].Width = 342;

            show();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            connection.Open();

            SqlCommand command = new SqlCommand("insert into CustomerMessages (adsoyad,mesaj) values('" + textBox1.Text + "','" + richTextBox1.Text + "')", connection);

            command.ExecuteNonQuery();

            MessageBox.Show("Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Clear();

            richTextBox1.Clear();

            connection.Close();

            show();

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        int id=0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;

            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
          
        }
    }
}
