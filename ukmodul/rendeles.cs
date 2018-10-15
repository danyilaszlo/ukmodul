using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MyNamespace;
using System.Collections;

namespace ukmodul
{
    public partial class rendelesForm : Form
    {

        // SqlConnection kapcs = new SqlConnection(@"Data Source=PC63\SQLEXPRESS;Initial Catalog=UKMODUL;Integrated Security=True");


        public static SqlConnection kapcs = new SqlConnection(@"Data Source=HPELITEBOOK\SQLEXPRESS;Initial Catalog=UKMODUL;Persist Security Info=True;User ID=sa;Password=SqlAdmin1");


        public rendelesForm()
        {
            InitializeComponent();

        }

        private void rendelesForm_Load(object sender, EventArgs e)
        {

            kapcs.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT vevo_nev FROM vevok", kapcs);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmboxVevonev.Items.Add(dr["vevo_nev"].ToString());
            }

            kapcs.Close();


            DGViewInit();
        }


        private void DGViewInit()
        {
            ArrayList row = new ArrayList();
            row.Add("");
            dgviewRendeles.Rows.Add(row.ToArray());


        }


        private void cmboxVevonev_SelectedIndexChanged(object sender, EventArgs e)
        {

            kapcs.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM vevok WHERE vevo_nev= '"+ cmboxVevonev.Text +"'", kapcs);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtKod.Text = (string)dr["vevo_id"].ToString();
                txtCim.Text = (string)dr["ir_szam"].ToString() + ", " + (string)dr["telepules_nev"].ToString() + ", " + (string)dr["cim"].ToString();
            }
            else
            {
                txtKod.Text = "nincs adat";
            }

            


            kapcs.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
