using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;


namespace Pansiyon_Kayit_Uygulamasi
{
    public partial class Customer_List_Frm : Form
    {
        public Customer_List_Frm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DMEJP7U\\SQLEXPRESS;Initial Catalog=tarco_pansiyon;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void show_customer()
        {
            connection.Open();

            SqlCommand command = new SqlCommand(@"select Musteriid AS[Customer ID],
                                                  Adi AS[Name],Soyadi AS[Surname],Cinsiyet AS[Gender],Telefon AS[Phone Number],
                                                  Mail AS[E-Mail],TC AS[Identity Number],
                                                  OdaNo AS[Room Number],Ucret AS[Room Charge],GirisTarihi AS[Entry],
                                                  CikisTarihi AS[Exit] from MusteriEkle Order By Musteriid", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            connection.Close();


        }



        private void Customer_List_Frm_Load(object sender, EventArgs e)
        {
            show_customer();

        }

        int id = 0;
        private void Customer_List_Frm_DoubleClick(object sender, EventArgs e)
        {


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var selectedrow = dataGridView1.SelectedRows[0];

            txtname.Text = selectedrow.Cells["Name"].Value.ToString();
            txtsurname.Text = selectedrow.Cells["Surname"].Value.ToString();
            comboBox1.Text = selectedrow.Cells["Gender"].Value.ToString();
            txtmail.Text = selectedrow.Cells["E-Mail"].Value.ToString();
            txtidentity.Text = selectedrow.Cells["Identity Number"].Value.ToString();
            txtroomno.Text = selectedrow.Cells["Room Number"].Value.ToString();
            txtroomcharge.Text = selectedrow.Cells["Room Charge"].Value.ToString();
            date_entry.Text = selectedrow.Cells["Entry"].Value.ToString();
            date_out.Text = selectedrow.Cells["Exit"].Value.ToString();
            txtphoneno.Text = selectedrow.Cells["Phone Number"].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();

            result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                connection.Open();
                var selectedrow = dataGridView1.SelectedRows[0];
                SqlCommand command = new SqlCommand("delete from MusteriEkle where Musteriid=(" + selectedrow.Cells["Customer ID"].Value.ToString() + ")", connection);
                SqlCommand command2=new SqlCommand("delete from Rooms where Oda=('" + selectedrow.Cells["Room Number"].Value.ToString()+"')",connection);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                connection.Close();
                show_customer();

                foreach (Control item in this.Controls)
                {

                    if (item is TextBox || item is MaskedTextBox || item is ComboBox || item is DateTimePicker)
                    {
                        if (item is TextBox)
                        {
                            TextBox textBox = (TextBox)item;

                            textBox.Clear();
                        }
                        else if (item is MaskedTextBox)
                        {
                            MaskedTextBox textBox = (MaskedTextBox)item;

                            textBox.Clear();
                        }
                        else if (item is ComboBox)
                        {
                            ComboBox item2 = (ComboBox)item;

                            item2.SelectedIndex = 0;
                        }
                        else
                        {
                            DateTimePicker item3 = (DateTimePicker)item;
                            item3.Value = DateTime.Now;
                        }


                    }

                }
            }
        }
        
        private void btnupdate_Click(object sender, EventArgs e)
        {
            var selectedrow = dataGridView1.SelectedRows[0];
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(@"update MusteriEkle set Adi='" + txtname.Text + "',Soyadi='" + txtsurname.Text + "'," +
                                                    "Cinsiyet='" + comboBox1.Text + "',Telefon='" + txtphoneno.Text + "'" +
                                                  ",TC='" + txtidentity.Text + "',OdaNo='" + txtroomno.Text + "',Ucret='" + txtroomcharge.Text + "'" +
                                                  ",GirisTarihi='" + date_entry.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + date_out.Value.ToString("yyyy-MM-dd") + "',Mail='" + txtmail.Text + "'" +
                                                  "where Musteriid='" + selectedrow.Cells["Customer ID"].Value.ToString() + "'", connection);

                command.ExecuteNonQuery();

                MessageBox.Show("Update successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();

                show_customer();
            }
            catch (Exception msg)
            {

                MessageBox.Show(msg.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                connection.Close();
            }




        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand(@"select Musteriid AS[Customer ID],
                                                  Adi AS[Name],Soyadi AS[Surname],Cinsiyet AS[Gender],Telefon AS[Phone Number],
                                                  Mail AS[E-Mail],TC AS[Identity Number],
                                                  OdaNo AS[Room Number],Ucret AS[Room Charge],GirisTarihi AS[Entry],
                                                  CikisTarihi AS[Exit] from MusteriEkle where Adi like '%" + txtsearch.Text + "%'", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

            connection.Close();
        }
    }
}
