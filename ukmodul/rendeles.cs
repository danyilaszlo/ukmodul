using System.Windows.Forms;

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        { }

        private void cikk_betoltes(ArrayList arrayList, object al)
        {
            throw new NotImplementedException();
        }

        private void dgviewRendeles_KeyPress(object sender, KeyPressEventArgs e)
        {

  
            if (dgviewRendeles.CurrentCell.ColumnIndex == 1 && e.KeyChar == (char)Keys.Enter)
            {
  
//                label2.Text = "Datagridview-ból a keresett string: " + dgviewRendeles.CurrentCell.Value.ToString();

                MessageBox.Show("keresett string: "dgviewRendeles.CurrentCell.Value.ToString());

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM cikkek WHERE cikk_nev LIKE '" + dgviewRendeles.CurrentCell.Value.ToString() + "'", kapcs);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DataRow dr ;
                if (dt.Rows.Count == 1)
                {
                    
                    int column_num = dgviewRendeles.CurrentCell.ColumnIndex;
                    int row_num = dgviewRendeles.CurrentCell.RowIndex;
                    MessageBox.Show("egy találat van, " + "oszlop: " + column_num + " , sor: " + row_num );
                    dr = dt.Rows[0];
                    
                    dgviewRendeles.Rows[row_num].Cells["cikk_id"].Value = dr["cikk_id"].ToString(); 
                    dgviewRendeles.CurrentCell.Value = dr["cikk_nev"];
                    dgviewRendeles.Rows[row_num].Cells["me"].Value = dr["me"].ToString();
                    dgviewRendeles.Rows[row_num].Cells["netto_ar"].Value = dr["netto_ar"].ToString();
                    dgviewRendeles.Rows[row_num].Cells["keszlet"].Value = dr["keszlet"].ToString();

                }
                else
                {
                    MessageBox.Show(dt.Rows.Count + " találat van");

                }

                e.Handled = true;

                //kapcs.Open();
                //SqlCommand cmd = new SqlCommand("SELECT * FROM cikkek WHERE cikk_nev LIKE '" + dgviewRendeles.CurrentCell.Value.ToString() + "' ", kapcs);
                //SqlDataReader dr = cmd.ExecuteReader();
                //if (dr.Read())
                //{
                //    int column_num = dgviewRendeles.CurrentCell.ColumnIndex;
                //    int row_num = dgviewRendeles.CurrentCell.RowIndex;

                //    dgvPoz.Text = "dgvPoz pozíció, oszlop: " + column_num.ToString() + ", " + row_num.ToString();

                //    label1.Text = dr["vevo_id"].ToString();
                //    dgviewRendeles.Rows[row_num].Cells[1].Value = (string)dr["vevo_id"].ToString();

                //    MessageBox.Show("IF ág...");

                //}
                //else
                //{
                //    MessageBox.Show("nincs adat");
                //}
                //kapcs.Close();

                //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM cikkek WHERE cikk_nev LIKE '" + dgviewRendeles.CurrentCell.Value.ToString() + "' ", kapcs);
                //DataTable dt = new DataTable();
                //sda.Fill(dt);

                //label3.Text = "Talált rekord db: " + dt.Rows.Count.ToString();

                //if (dt.Rows.Count == 1)
                //{

                //    label1.Text = "Keresés eredménye: " + dt.Rows[0].ToString();

                //    // a talált cikk adatait betölteni a datagridview-ba

                //    dgviewRendeles.Rows[0].Cells[0].Value = "v121212"; //dr.ToString();

                //    //foreach (DataRow dr in dt.Rows)
                //    //{
                //    //    dgviewRendeles.Rows[0].Cells[0].Value = "v121212" //dr.ToString();

                //    //}


                //    // ArrayList al = new ArrayList();

                //    //al.Add(dt.Rows[0].["cikk_id"].toString());
                //    //al.Add(dt.Rows[1]);
                //    //al.Add("");
                //    //al.Add(dt.Rows[2]);
                //    //al.Add(dt.Rows[3]);
                //    //al.Add(dt.Rows[6]);
                //    //al.Add("0");
                //    //al.Add("0");

                //    //cikk_betoltes(al);


                //}
                //else if (dt.Rows.Count > 1)
                //     {

                //            // új modal ablak a talált rekordok listájával, nyilakkal, enterrel cikket lehet választani ami betöltődik a datagridview-ba

                //     }
                //     else
                //     {
                //         MessageBox.Show("Nincs ilyen termék!");
                //     }

            }





        }
    }
}
