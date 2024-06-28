using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace UpdateRooms

{
    class Room
    {

        public string Oda { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }
    }

    class UpdateRoom
    {

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DMEJP7U\\SQLEXPRESS;Initial Catalog=tarco_pansiyon;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        public virtual void Update_Rooms(Form form1)
        {
            connection.Open();
            List<Room> list = new List<Room>();

            SqlCommand command = new SqlCommand("select * from Rooms", connection);

            SqlDataReader sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {

                list.Add(new Room
                {
                    Oda = sqlDataReader["Oda"].ToString(),
                    Adi = sqlDataReader["Adi"].ToString(),
                    Soyadi = sqlDataReader["Soyadi"].ToString()
                });

            }
            sqlDataReader.Close();
            connection.Close();

            foreach (Control item in form1.Controls)
            {

                if (item is Button)
                {
                    Button btn = (Button)item;

                    foreach (var room in list)
                    {
                        if (room.Oda == btn.Text)
                        {
                            btn.Text = room.Adi + " " + room.Soyadi;
                            btn.BackColor = Color.Red;
                            break;
                        }

                    }
                }
            }


        }

        public virtual void Update_Rooms(GroupBox group)
        {
            connection.Open();
            List<Room> list = new List<Room>();

            SqlCommand command = new SqlCommand("select * from Rooms", connection);

            SqlDataReader sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {

                list.Add(new Room
                {
                    Oda = sqlDataReader["Oda"].ToString(),
                    Adi = sqlDataReader["Adi"].ToString(),
                    Soyadi = sqlDataReader["Soyadi"].ToString()
                });

            }
            sqlDataReader.Close();
            connection.Close();

            foreach (Control item in group.Controls)
            {

                if (item is Button)
                {
                    Button btn = (Button)item;

                    foreach (var room in list)
                    {
                        if (room.Oda == btn.Text)
                        {
                            btn.Text = room.Adi + " " + room.Soyadi;
                            btn.BackColor = Color.Red;
                            break;
                        }

                    }
                }
            }


        }
    }

}

