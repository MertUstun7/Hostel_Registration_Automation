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
    public partial class radiofrm : Form
    {
        public radiofrm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\EXCALIBUR\\Desktop\\Pansiyon_Kayit_Uygulamasi\\Musics\\music1.m4a";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\EXCALIBUR\\Desktop\\Pansiyon_Kayit_Uygulamasi\\Musics\\music2.m4a";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\EXCALIBUR\\Desktop\\Pansiyon_Kayit_Uygulamasi\\Musics\\music3.m4a";
        }

        private void radiofrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void radiofrm_Load(object sender, EventArgs e)
        {

        }
    }
}
