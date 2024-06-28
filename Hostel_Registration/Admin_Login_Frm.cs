using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Pansiyon_Kayit_Uygulamasi
{
    public partial class Admin_Login_Frm : Form
    {
        public Admin_Login_Frm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DMEJP7U\\SQLEXPRESS;Initial Catalog=tarco_pansiyon;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string cmd = "select * from Admins where UserName=@admin AND Password=@password";

                SqlParameter p1 = new SqlParameter("admin", txtuser.Text.Trim());

                SqlParameter p2 = new SqlParameter("password", txtpassword.Text.Trim());

                SqlCommand command = new SqlCommand(cmd, connection);

                command.Parameters.Add(p1);

                command.Parameters.Add(p2);

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Main_Page_Frm main_Page_Frm = new Main_Page_Frm();
                    this.Hide();
                    main_Page_Frm.ShowDialog();
                    
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Check Entry Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Admin_Login_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminregisterfrm adminregisterfrm = new adminregisterfrm();

            adminregisterfrm.ShowDialog();

            
        }
    }
}
