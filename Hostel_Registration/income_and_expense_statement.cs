using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Kayit_Uygulamasi
{
    public partial class income_and_expense_statement : Form
    {
        public income_and_expense_statement()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DMEJP7U\\SQLEXPRESS;Initial Catalog=tarco_pansiyon;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        int sum_of_room_fee = 0;
        int sum_of_salary = 0;

        void updatecolmn()
        {

            string connectionString = "Data Source=DESKTOP-DMEJP7U\\SQLEXPRESS;Initial Catalog=tarco_pansiyon;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            string updateQuery = @"
                WITH Toplamlar AS (
                    SELECT
                        tarih,
                        SUM(Urun) AS Alinan_Urunlerin_Toplami,
                        SUM(Fatura) AS Faturalar
                    FROM UrunveFatura
                    GROUP BY tarih
                )
                UPDATE Giderler
                SET
                    Giderler.Alinan_Urunlerin_Toplami = Toplamlar.Alinan_Urunlerin_Toplami,
                    Giderler.Faturalar = Toplamlar.Faturalar
                FROM Giderler
                INNER JOIN Toplamlar ON Giderler.Date = Toplamlar.tarih;
            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(updateQuery, connection);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }


            }
            connection.Open();

            SqlCommand command2= new SqlCommand("update Giderler set Net_Kasa=Kasadaki_Toplam_Para-Personel_Maas-Alinan_Urunlerin_Toplami-Faturalar",connection);

            command2.ExecuteNonQuery();
            connection.Close();
            
        }
        private void income_and_expense_statement_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Select sum(Ucret) as toplam from MusteriEkle", connection);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {

                    sum_of_room_fee = Convert.ToInt32(reader["toplam"]);
                
                }

                connection.Close();

                connection.Open();
                SqlCommand cmd2 = new SqlCommand("Select sum(Maas) as toplam from Employees", connection);

                SqlDataReader reader2 = cmd2.ExecuteReader();

                while (reader2.Read()) {

                    sum_of_salary = Convert.ToInt32(reader2["toplam"]);
                
                }

                connection.Close();
                connection.Open();

                SqlCommand cmd4 = new SqlCommand("insert into Giderler(Kasadaki_Toplam_Para,Personel_Maas) values('" + sum_of_room_fee + "','" + sum_of_salary + "')", connection);

                cmd4.ExecuteNonQuery();

                connection.Close();


                updatecolmn();
       
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(@"select Kasadaki_Toplam_Para AS[Cash Register],Personel_Maas AS[Employe Salary],Alinan_Urunlerin_Toplami AS[Products],Faturalar AS[Bills],Net_Kasa AS[Total],Date from Giderler Order by Date", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                connection.Close();




            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Information", MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }




           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
