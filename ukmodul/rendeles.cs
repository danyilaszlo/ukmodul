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
<<<<<<< HEAD
        //public static SqlConnection kapcs = new SqlConnection(@"Data Source=PC63\SQLEXPRESS;Initial Catalog=UKMODUL;Integrated Security=True");
        public static SqlConnection kapcs = new SqlConnection(@"Data Source=HPELITEBOOK\SQLEXPRESS;Initial Catalog=UKMODUL;Persist Security Info=True;User ID=sa;Password=SqlAdmin1");
=======
         //public static SqlConnection kapcs = new SqlConnection(@"Data Source=PC63\SQLEXPRESS;Initial Catalog=UKMODUL;Integrated Security=True");
        public static SqlConnection kapcs = new SqlConnection(@"Data Source=HPELITEBOOK\SQLEXPRESS;Initial Catalog=UKMODUL;Persist Security Info=True;User ID=sa;Password=SqlAdmin1");

>>>>>>> 25e7366ae6fb7ebefdf462fe4ee78038a64d8dd0

        int column_index, row_index;
        int netto, brutto;
        int netto_ossz = 0, brutto_ossz = 0;
        int afa_kulcs = 0;
        DataRow dr;

        public rendelesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A vevő kiválasztásához feltölti adatokkal a combobox-ot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rendelesForm_Load(object sender, EventArgs e)
        {

            txtRogzDat.Text = DateTime.Today.ToString("yyyy/MM/dd");

            kapcs.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT vevo_nev FROM vevok", kapcs);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmboxVevonev.Items.Add(dr["vevo_nev"].ToString());
            }
            kapcs.Close();
<<<<<<< HEAD
            dgviewRendelesInit();
        }

        /// <summary>
        /// Az első sort egy üres sorral tölti fel a datagridview-be
        /// </summary>
        private void dgviewRendelesInit()
        {
            // ArrayList row = new ArrayList();
            //row.Add();
            //dgvRendeles.Rows.Add(row.ToArray());

            dgvRendeles.Rows.Add();
            row_index = dgvRendeles.CurrentCell.RowIndex;
            dgvRendeles.Rows[row_index].Cells["cikk_id"].Value = "";
            dgvRendeles.Rows[row_index].Cells["cikk_nev"].Value = "";
            dgvRendeles.Rows[row_index].Cells["me"].Value = "";
            dgvRendeles.Rows[row_index].Cells["netto_ar"].Value = "";
            dgvRendeles.Rows[row_index].Cells["keszlet"].Value = "";



            dgvRendeles.CurrentCell = dgvRendeles[1, dgvRendeles.RowCount - 1];


//            row_index = dgvRendeles.CurrentCell.RowIndex;
            
=======

            dgviewRendelesInit();

        }

>>>>>>> 25e7366ae6fb7ebefdf462fe4ee78038a64d8dd0


        }

        /// <summary>
        /// A comboboxban kiválasztott vevők adatait tölti be a kód és cím textboxokba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmboxVevonev_SelectedIndexChanged(object sender, EventArgs e)
        {
            kapcs.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM vevok WHERE vevo_nev= '" + cmboxVevonev.Text + "'", kapcs);
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

<<<<<<< HEAD
        /// <summary>
        /// Rendelés form bezárása
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// A kiválasztott termék adatainak betöltése a dgvRendelés aktuális sorába
        /// </summary>
        /// <param name="arrayList"></param>
        /// <param name="al"></param>
        private void cikk_betoltes()
        {
            dgvRendeles.Rows[row_index].Cells["cikk_id"].Value = dr["cikk_id"].ToString();
            dgvRendeles.Rows[row_index].Cells["cikk_nev"].Value = dr["cikk_nev"];
            dgvRendeles.Rows[row_index].Cells["me"].Value = dr["me"].ToString();
            dgvRendeles.Rows[row_index].Cells["netto_ar"].Value = dr["netto_ar"].ToString();
            dgvRendeles.Rows[row_index].Cells["keszlet"].Value = dr["keszlet"].ToString();
 

        }

        /// <summary>
        /// Termék keresés indítása: ha ("Enter"-t nyomott és "cikk_nev" cellában áll a kurzor)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgviewRendeles_KeyPress(object sender, KeyPressEventArgs e)
        {
            column_index = dgvRendeles.CurrentCell.ColumnIndex;
            row_index = dgvRendeles.CurrentCell.RowIndex;

            if (e.KeyChar == (char)Keys.Enter && dgvRendeles.CurrentCell.Value.ToString() != "")
            {
                if (dgvRendeles.CurrentCell.ColumnIndex == 1)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM cikkek WHERE cikk_nev LIKE '" + dgvRendeles.CurrentCell.Value.ToString() + "'", kapcs);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    MessageBox.Show(dt.Rows.Count + " találat van, " + "oszlop: " + column_index + " , sor: " + row_index);

                    if (dt.Rows.Count == 1)
                    {
                        dr = dt.Rows[0];
                        cikk_betoltes();
                        dgvRendeles.CurrentCell = dgvRendeles[column_index + 1, row_index];
                    }
                    else if (dt.Rows.Count > 1)
                            {
                                selectCikkForm selectCikkFrm = new selectCikkForm();
                                selectCikkFrm.Show();

                                //....

                                //dgvRendeles.CurrentCell = dgvRendeles[column_index + 1, row_index];
                            }
                            else
                            {
                                MessageBox.Show("Nincs ilyen termék");
                            }

                    e.Handled = true;
                }
                else if (dgvRendeles.CurrentCell.ColumnIndex == 2)
                        {

                    // dr indexet beállítani, mert most mindig 0
                   // MessageBox.Show("switch ág...");

                            netto = Convert.ToInt32(dr["netto_ar"]) * Convert.ToInt32(dgvRendeles.Rows[dgvRendeles.CurrentCell.RowIndex].Cells["rend_menny"].Value);

                            switch (dr["afa"])
                            {
                                case "K27":
                                    afa_kulcs = 27;
                                    break;
                                case "K18":
                                    afa_kulcs = 18;
                                    break;
                                case "K05":
                                    afa_kulcs = 5;
                                    break;
                            }

                            brutto = netto + ((netto * afa_kulcs) / 100);
                            dgvRendeles.Rows[dgvRendeles.CurrentCell.RowIndex].Cells["netto_ertek"].Value = netto.ToString();
                            dgvRendeles.Rows[dgvRendeles.CurrentCell.RowIndex].Cells["brutto_ertek"].Value = brutto.ToString();
                            Osszesites();
                            dgvRendeles[1, dgvRendeles.CurrentCell.RowIndex].ReadOnly = true;
                            dgviewRendelesInit();

                }
            }
=======
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
>>>>>>> 25e7366ae6fb7ebefdf462fe4ee78038a64d8dd0

        }


        private void Osszesites()
        {
            netto_ossz += netto;
            brutto_ossz += brutto;

            txtNettoOssz.Text = netto_ossz.ToString();
            txtBruttoOssz.Text = brutto_ossz.ToString();


<<<<<<< HEAD
=======


        }
>>>>>>> 25e7366ae6fb7ebefdf462fe4ee78038a64d8dd0
    }
}
