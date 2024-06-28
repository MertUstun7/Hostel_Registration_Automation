using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using UpdateRooms;
namespace Pansiyon_Kayit_Uygulamasi
{
    public partial class Roomsfrm : Form
    {
        public Roomsfrm()
        {
            InitializeComponent();
        }




        private void Roomsfrm_Load(object sender, EventArgs e)
        {


            UpdateRoom updateRoom = new UpdateRoom();

            updateRoom.Update_Rooms(this);


        }
    }
}

