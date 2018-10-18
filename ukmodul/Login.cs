using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ukmodul
{


    public partial class frmLogin : Form
    {

        
        //public static string kapcs_string = @"Data Source=PC63\SQLEXPRESS;Initial Catalog=UKMODUL;Integrated Security=True";

        public static string kapcs_string = @"Data Source=HPELITEBOOK\SQLEXPRESS;Initial Catalog=UKMODUL;Persist Security Info=True;User ID=sa;Password=SqlAdmin1";



        public frmLogin()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlConnection kapcs = new SqlConnection(kapcs_string);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM felhasznalok WHERE felhaszn_nev = '"+ txtUsername.Text +"' AND passwd = '"+ txtPasswd.Text+"'", kapcs);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                main frmMain = new main();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Hibás név vagy jelszó!");
                txtUsername.Focus();
  
            }
        }

        private void txtPasswd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
