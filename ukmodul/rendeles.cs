using System.Windows.Forms;

﻿using System;
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
using System.Collections;


namespace ukmodul
{
    public partial class rendelesForm : Form
    {
         public static SqlConnection kapcs = new SqlConnection(@"Data Source=PC63\SQLEXPRESS;Initial Catalog=UKMODUL;Integrated Security=True");


        //public static SqlConnection kapcs = new SqlConnection(@"Data Source=HPELITEBOOK\SQLEXPRESS;Initial Catalog=UKMODUL;Persist Security Info=True;User ID=sa;Password=SqlAdmin1");



        public rendelesForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Comboboxba tölti a vevők adatait az adatbázisból
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            dgviewRendelesInit();
        }

        /// <summary>
        /// Az első sort egy üres sorral tölti fel a datagridview-be
        /// </summary>
        private void dgviewRendelesInit()
        {
            ArrayList row = new ArrayList();
            row.Add("");
            dgviewRendeles.Rows.Add(row.ToArray());
        }


        /// <summary>
        /// A comboboxban kiválasztott vevők adatait tölti be a kód és cím textboxokba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            
        private void dgviewRendeles_KeyDown(object sender, KeyEventArgs e)
        {


            if (dgviewRendeles.CurrentCell.ColumnIndex == 1 && e.KeyData == Keys.Enter)
            {





            }


        }
    }
}
