using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using UpdateRooms;
using System.Drawing.Text;

namespace Pansiyon_Kayit_Uygulamasi
{
    public partial class New_Customer_Frm : Form
    {
        public New_Customer_Frm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DMEJP7U\\SQLEXPRESS;Initial Catalog=tarco_pansiyon;Integrated Security=True;Trust Server Certificate=True");

        
       public void roomno(string no)
        {
            txtroomno.Text = no;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            roomno(btnoda4.Text);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Red buttons show us that the room is full.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       private void guncelle()
        {

           foreach (Control item in groupBox2.Controls)
            {
                if (item is Button)
                {
                    if(item.BackColor == Color.Red){

                        item.Enabled = false;
                    }

                }

            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
           

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void YeniMusteriFrm_Load(object sender, EventArgs e)
        {
            foreach (Control control in groupBox2.Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;
                    btn.Click += new EventHandler(Button_Click);
                }
            }
            UpdateRoom updt = new UpdateRoom();
            updt.Update_Rooms(this.groupBox2);

            guncelle();
       
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton != null)
            {
                string buttontext = clickedButton.Text;
                roomno(buttontext);
            }



        }

        private void btnempty_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Green button show us that the room is empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        void calculate_price(DateTime d1, DateTime d2)
        {
            double price = 0;
            TimeSpan timespan = d1 - d2;
            label11.Text = timespan.TotalDays.ToString();

            price = Convert.ToInt32(label11.Text) * 1000;

            txtroomcharge.Text = price.ToString();
        }
        private void date_out_ValueChanged(object sender, EventArgs e)
        {
            DateTime d1 = Convert.ToDateTime(date_out.Text);

            DateTime d2 = Convert.ToDateTime(date_entry.Text);

            calculate_price(d1, d2);



        }

        private void date_entry_ValueChanged(object sender, EventArgs e)
        {
            date_out_ValueChanged(null, null);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                if(txtroomno.Text == string.Empty)
                {
                    MessageBox.Show("Please choose room", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { 
                SqlCommand command = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + txtname.Text + "','" + txtsurname.Text + "','" + comboBox1.Text + "','" + txtphoneno.Text + "','" + txtmail.Text + "','" + txtidentity.Text + "','" + txtroomno.Text + "','" + txtroomcharge.Text + "','" + date_entry.Value.ToString("yyyy-MM-dd") + "','" + date_out.Value.ToString("yyyy-MM-dd") + "')", connection);
                SqlCommand command2 = new SqlCommand("insert into Rooms(Adi,Soyadi,Oda) values('" + txtname.Text + "','" + txtsurname.Text + "','" + txtroomno.Text + "')", connection);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                MessageBox.Show("Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

               

                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox txt = (TextBox)item;
                        txt.Clear();
                    }
                }
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is ComboBox)
                    {
                        ComboBox cmb = (ComboBox)item;
                        cmb.SelectedIndex = 0;
                    }
                }

                foreach (Control item in groupBox1.Controls)
                {
                    if (item is MaskedTextBox)
                    {

                        MaskedTextBox txt = (MaskedTextBox)item;
                        txt.Clear();
                    }
                }
            }
            }
            catch (Exception msg)
            {

                MessageBox.Show(msg.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                connection.Close();
            }
            UpdateRoom updt = new UpdateRoom();
            updt.Update_Rooms(this.groupBox2);
            guncelle();
            connection.Close();
        
    }
    }
}
