namespace ukmodul
{
    partial class rendelesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelKod = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.labelVevonev = new System.Windows.Forms.Label();
            this.cmboxVevonev = new System.Windows.Forms.ComboBox();
            this.btnVevok = new System.Windows.Forms.Button();
            this.labelCim = new System.Windows.Forms.Label();
            this.txtCim = new System.Windows.Forms.TextBox();
            this.dgviewRendeles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPoz = new System.Windows.Forms.Label();
            this.cikk_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikk_nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rend_menny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.me = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netto_ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keszlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netto_ertek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutto_ertek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewRendeles)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKod
            // 
            this.labelKod.AutoSize = true;
            this.labelKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKod.Location = new System.Drawing.Point(16, 21);
            this.labelKod.Name = "labelKod";
            this.labelKod.Size = new System.Drawing.Size(41, 20);
            this.labelKod.TabIndex = 0;
            this.labelKod.Text = "Kód:";
            // 
            // txtKod
            // 
            this.txtKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKod.Location = new System.Drawing.Point(70, 18);
            this.txtKod.Name = "txtKod";
            this.txtKod.ReadOnly = true;
            this.txtKod.Size = new System.Drawing.Size(100, 26);
            this.txtKod.TabIndex = 1;
            // 
            // labelVevonev
            // 
            this.labelVevonev.AutoSize = true;
            this.labelVevonev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVevonev.Location = new System.Drawing.Point(194, 21);
            this.labelVevonev.Name = "labelVevonev";
            this.labelVevonev.Size = new System.Drawing.Size(40, 20);
            this.labelVevonev.TabIndex = 2;
            this.labelVevonev.Text = "Név:";
            // 
            // cmboxVevonev
            // 
            this.cmboxVevonev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxVevonev.FormattingEnabled = true;
            this.cmboxVevonev.Location = new System.Drawing.Point(255, 17);
            this.cmboxVevonev.Name = "cmboxVevonev";
            this.cmboxVevonev.Size = new System.Drawing.Size(198, 28);
            this.cmboxVevonev.TabIndex = 3;
            this.cmboxVevonev.SelectedIndexChanged += new System.EventHandler(this.cmboxVevonev_SelectedIndexChanged);
            // 
            // btnVevok
            // 
            this.btnVevok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVevok.Location = new System.Drawing.Point(487, 15);
            this.btnVevok.Name = "btnVevok";
            this.btnVevok.Size = new System.Drawing.Size(76, 30);
            this.btnVevok.TabIndex = 4;
            this.btnVevok.Text = "Vevők...";
            this.btnVevok.UseVisualStyleBackColor = true;
            // 
            // labelCim
            // 
            this.labelCim.AutoSize = true;
            this.labelCim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCim.Location = new System.Drawing.Point(16, 65);
            this.labelCim.Name = "labelCim";
            this.labelCim.Size = new System.Drawing.Size(40, 20);
            this.labelCim.TabIndex = 5;
            this.labelCim.Text = "Cím:";
            // 
            // txtCim
            // 
            this.txtCim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCim.Location = new System.Drawing.Point(70, 62);
            this.txtCim.Name = "txtCim";
            this.txtCim.Size = new System.Drawing.Size(493, 26);
            this.txtCim.TabIndex = 6;
            // 
            // dgviewRendeles
            // 
            this.dgviewRendeles.AllowUserToAddRows = false;
            this.dgviewRendeles.AllowUserToDeleteRows = false;
            this.dgviewRendeles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgviewRendeles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewRendeles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cikk_id,
            this.cikk_nev,
            this.rend_menny,
            this.me,
            this.netto_ar,
            this.keszlet,
            this.netto_ertek,
            this.brutto_ertek});
            this.dgviewRendeles.Location = new System.Drawing.Point(12, 113);
            this.dgviewRendeles.Name = "dgviewRendeles";
<<<<<<< HEAD
            this.dgviewRendeles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgviewRendeles.Size = new System.Drawing.Size(1247, 526);
=======
            this.dgviewRendeles.Size = new System.Drawing.Size(1247, 547);
>>>>>>> 178d11ace346d9fcbc4743c70dd4673f89a3b077
            this.dgviewRendeles.TabIndex = 7;
            this.dgviewRendeles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgviewRendeles_KeyDown);
            this.dgviewRendeles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgviewRendeles_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(594, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Keresés eredménye: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(591, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datagridview-ból a keresett string: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(595, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Talált rekord db: ";
            // 
            // dgvPoz
            // 
            this.dgvPoz.AutoSize = true;
            this.dgvPoz.Location = new System.Drawing.Point(949, 76);
            this.dgvPoz.Name = "dgvPoz";
            this.dgvPoz.Size = new System.Drawing.Size(69, 13);
            this.dgvPoz.TabIndex = 10;
            this.dgvPoz.Text = "dgv pozíció: ";
            // 
            // cikk_id
            // 
            this.cikk_id.DataPropertyName = "cikk_id";
            this.cikk_id.FillWeight = 41.15464F;
            this.cikk_id.HeaderText = "Cikkszám";
            this.cikk_id.Name = "cikk_id";
            this.cikk_id.ReadOnly = true;
            this.cikk_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cikk_nev
            // 
            this.cikk_nev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cikk_nev.FillWeight = 355.3299F;
            this.cikk_nev.HeaderText = "Termék neve";
            this.cikk_nev.Name = "cikk_nev";
            this.cikk_nev.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // rend_menny
            // 
            this.rend_menny.FillWeight = 60.70308F;
            this.rend_menny.HeaderText = "Mennyiség";
            this.rend_menny.Name = "rend_menny";
            this.rend_menny.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // me
            // 
            this.me.FillWeight = 60.70308F;
            this.me.HeaderText = "ME";
            this.me.Name = "me";
            this.me.ReadOnly = true;
            this.me.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // netto_ar
            // 
            this.netto_ar.FillWeight = 60.70308F;
            this.netto_ar.HeaderText = "Egységár";
            this.netto_ar.Name = "netto_ar";
            this.netto_ar.ReadOnly = true;
            this.netto_ar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // keszlet
            // 
            this.keszlet.HeaderText = "Készlet";
            this.keszlet.Name = "keszlet";
            // 
            // netto_ertek
            // 
            this.netto_ertek.FillWeight = 60.70308F;
            this.netto_ertek.HeaderText = "Nettó érték";
            this.netto_ertek.Name = "netto_ertek";
            this.netto_ertek.ReadOnly = true;
            this.netto_ertek.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // brutto_ertek
            // 
            this.brutto_ertek.FillWeight = 60.70308F;
            this.brutto_ertek.HeaderText = "Bruttó érték";
            this.brutto_ertek.Name = "brutto_ertek";
            this.brutto_ertek.ReadOnly = true;
            this.brutto_ertek.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // rendelesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 739);
            this.Controls.Add(this.dgvPoz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgviewRendeles);
            this.Controls.Add(this.txtCim);
            this.Controls.Add(this.labelCim);
            this.Controls.Add(this.btnVevok);
            this.Controls.Add(this.cmboxVevonev);
            this.Controls.Add(this.labelVevonev);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.labelKod);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rendelesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rendelés";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rendelesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewRendeles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKod;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label labelVevonev;
        private System.Windows.Forms.ComboBox cmboxVevonev;
        private System.Windows.Forms.Button btnVevok;
        private System.Windows.Forms.Label labelCim;
        private System.Windows.Forms.TextBox txtCim;
        private System.Windows.Forms.DataGridView dgviewRendeles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dgvPoz;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikk_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikk_nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn rend_menny;
        private System.Windows.Forms.DataGridViewTextBoxColumn me;
        private System.Windows.Forms.DataGridViewTextBoxColumn netto_ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn keszlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn netto_ertek;
        private System.Windows.Forms.DataGridViewTextBoxColumn brutto_ertek;
    }
}