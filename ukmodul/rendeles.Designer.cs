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
            this.dgvRendeles = new System.Windows.Forms.DataGridView();
            this.cikk_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikk_nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rend_menny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.me = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netto_ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keszlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netto_ertek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutto_ertek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSzallDat = new System.Windows.Forms.Label();
            this.lblAzonosito = new System.Windows.Forms.Label();
            this.lblRogzDat = new System.Windows.Forms.Label();
            this.txtKintlevo = new System.Windows.Forms.TextBox();
            this.txtSzallDat = new System.Windows.Forms.TextBox();
            this.txtAzonosito = new System.Windows.Forms.TextBox();
            this.txtRogzDat = new System.Windows.Forms.TextBox();
            this.lblTetelmegjegyzes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSorTorles = new System.Windows.Forms.Button();
            this.btnUjRendeles = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtNettoOssz = new System.Windows.Forms.TextBox();
            this.txtBruttoOssz = new System.Windows.Forms.TextBox();
            this.lblNettoOssz = new System.Windows.Forms.Label();
            this.lblBruttoOssz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendeles)).BeginInit();
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
            this.cmboxVevonev.Location = new System.Drawing.Point(255, 18);
            this.cmboxVevonev.Name = "cmboxVevonev";
            this.cmboxVevonev.Size = new System.Drawing.Size(198, 28);
            this.cmboxVevonev.TabIndex = 3;
            this.cmboxVevonev.SelectedIndexChanged += new System.EventHandler(this.cmboxVevonev_SelectedIndexChanged);
            // 
            // btnVevok
            // 
            this.btnVevok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVevok.Location = new System.Drawing.Point(487, 18);
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
            // dgvRendeles
            // 
            this.dgvRendeles.AllowUserToAddRows = false;
            this.dgvRendeles.AllowUserToDeleteRows = false;
            this.dgvRendeles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRendeles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRendeles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cikk_id,
            this.cikk_nev,
            this.rend_menny,
            this.me,
            this.netto_ar,
            this.keszlet,
            this.netto_ertek,
            this.brutto_ertek});
            this.dgvRendeles.Location = new System.Drawing.Point(12, 113);
            this.dgvRendeles.Name = "dgvRendeles";
            this.dgvRendeles.Size = new System.Drawing.Size(1247, 547);
            this.dgvRendeles.TabIndex = 7;
            this.dgvRendeles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgviewRendeles_KeyPress);
            // 
            // cikk_id
            // 
            this.cikk_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cikk_id.DataPropertyName = "cikk_id";
            this.cikk_id.FillWeight = 41.15464F;
            this.cikk_id.HeaderText = "Cikkszám";
            this.cikk_id.Name = "cikk_id";
            this.cikk_id.ReadOnly = true;
            this.cikk_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cikk_id.Width = 62;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(647, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kintlévőség:";
            // 
            // lblSzallDat
            // 
            this.lblSzallDat.AutoSize = true;
            this.lblSzallDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSzallDat.Location = new System.Drawing.Point(611, 65);
            this.lblSzallDat.Name = "lblSzallDat";
            this.lblSzallDat.Size = new System.Drawing.Size(130, 20);
            this.lblSzallDat.TabIndex = 9;
            this.lblSzallDat.Text = "Szállítás dátuma:";
            // 
            // lblAzonosito
            // 
            this.lblAzonosito.AutoSize = true;
            this.lblAzonosito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAzonosito.Location = new System.Drawing.Point(1029, 21);
            this.lblAzonosito.Name = "lblAzonosito";
            this.lblAzonosito.Size = new System.Drawing.Size(84, 20);
            this.lblAzonosito.TabIndex = 10;
            this.lblAzonosito.Text = "Azonosító:";
            // 
            // lblRogzDat
            // 
            this.lblRogzDat.AutoSize = true;
            this.lblRogzDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRogzDat.Location = new System.Drawing.Point(979, 65);
            this.lblRogzDat.Name = "lblRogzDat";
            this.lblRogzDat.Size = new System.Drawing.Size(134, 20);
            this.lblRogzDat.TabIndex = 11;
            this.lblRogzDat.Text = "Rögzítés dátuma:";
            // 
            // txtKintlevo
            // 
            this.txtKintlevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKintlevo.Location = new System.Drawing.Point(744, 18);
            this.txtKintlevo.Name = "txtKintlevo";
            this.txtKintlevo.Size = new System.Drawing.Size(100, 26);
            this.txtKintlevo.TabIndex = 12;
            // 
            // txtSzallDat
            // 
            this.txtSzallDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSzallDat.Location = new System.Drawing.Point(744, 62);
            this.txtSzallDat.Name = "txtSzallDat";
            this.txtSzallDat.Size = new System.Drawing.Size(100, 26);
            this.txtSzallDat.TabIndex = 13;
            // 
            // txtAzonosito
            // 
            this.txtAzonosito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAzonosito.Location = new System.Drawing.Point(1116, 18);
            this.txtAzonosito.Name = "txtAzonosito";
            this.txtAzonosito.ReadOnly = true;
            this.txtAzonosito.Size = new System.Drawing.Size(100, 26);
            this.txtAzonosito.TabIndex = 14;
            // 
            // txtRogzDat
            // 
            this.txtRogzDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRogzDat.Location = new System.Drawing.Point(1116, 62);
            this.txtRogzDat.Name = "txtRogzDat";
            this.txtRogzDat.ReadOnly = true;
            this.txtRogzDat.Size = new System.Drawing.Size(100, 26);
            this.txtRogzDat.TabIndex = 15;
            // 
            // lblTetelmegjegyzes
            // 
            this.lblTetelmegjegyzes.AutoSize = true;
            this.lblTetelmegjegyzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTetelmegjegyzes.Location = new System.Drawing.Point(45, 678);
            this.lblTetelmegjegyzes.Name = "lblTetelmegjegyzes";
            this.lblTetelmegjegyzes.Size = new System.Drawing.Size(136, 20);
            this.lblTetelmegjegyzes.TabIndex = 16;
            this.lblTetelmegjegyzes.Text = "Tétel megjegyzés:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 713);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Rendelés megjegyzés:";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOK.Location = new System.Drawing.Point(20, 780);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 29);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(112, 780);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Mégse";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSorTorles
            // 
            this.btnSorTorles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSorTorles.Location = new System.Drawing.Point(265, 780);
            this.btnSorTorles.Name = "btnSorTorles";
            this.btnSorTorles.Size = new System.Drawing.Size(106, 29);
            this.btnSorTorles.TabIndex = 20;
            this.btnSorTorles.Text = "Sor törlés";
            this.btnSorTorles.UseVisualStyleBackColor = true;
            // 
            // btnUjRendeles
            // 
            this.btnUjRendeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUjRendeles.Location = new System.Drawing.Point(404, 780);
            this.btnUjRendeles.Name = "btnUjRendeles";
            this.btnUjRendeles.Size = new System.Drawing.Size(111, 29);
            this.btnUjRendeles.TabIndex = 21;
            this.btnUjRendeles.Text = "Új rendelés";
            this.btnUjRendeles.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(184, 675);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1063, 26);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(184, 710);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1063, 26);
            this.textBox2.TabIndex = 23;
            // 
            // txtNettoOssz
            // 
            this.txtNettoOssz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNettoOssz.Location = new System.Drawing.Point(1002, 783);
            this.txtNettoOssz.Name = "txtNettoOssz";
            this.txtNettoOssz.Size = new System.Drawing.Size(100, 26);
            this.txtNettoOssz.TabIndex = 24;
            // 
            // txtBruttoOssz
            // 
            this.txtBruttoOssz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBruttoOssz.Location = new System.Drawing.Point(1138, 783);
            this.txtBruttoOssz.Name = "txtBruttoOssz";
            this.txtBruttoOssz.Size = new System.Drawing.Size(100, 26);
            this.txtBruttoOssz.TabIndex = 25;
            // 
            // lblNettoOssz
            // 
            this.lblNettoOssz.AutoSize = true;
            this.lblNettoOssz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNettoOssz.Location = new System.Drawing.Point(1002, 754);
            this.lblNettoOssz.Name = "lblNettoOssz";
            this.lblNettoOssz.Size = new System.Drawing.Size(88, 20);
            this.lblNettoOssz.TabIndex = 26;
            this.lblNettoOssz.Text = "Nettó érték";
            // 
            // lblBruttoOssz
            // 
            this.lblBruttoOssz.AutoSize = true;
            this.lblBruttoOssz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBruttoOssz.Location = new System.Drawing.Point(1135, 754);
            this.lblBruttoOssz.Name = "lblBruttoOssz";
            this.lblBruttoOssz.Size = new System.Drawing.Size(97, 20);
            this.lblBruttoOssz.TabIndex = 27;
            this.lblBruttoOssz.Text = "Bruttó érték:";
            // 
            // rendelesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 825);
            this.Controls.Add(this.lblBruttoOssz);
            this.Controls.Add(this.lblNettoOssz);
            this.Controls.Add(this.txtBruttoOssz);
            this.Controls.Add(this.txtNettoOssz);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUjRendeles);
            this.Controls.Add(this.btnSorTorles);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTetelmegjegyzes);
            this.Controls.Add(this.txtRogzDat);
            this.Controls.Add(this.txtAzonosito);
            this.Controls.Add(this.txtSzallDat);
            this.Controls.Add(this.txtKintlevo);
            this.Controls.Add(this.lblRogzDat);
            this.Controls.Add(this.lblAzonosito);
            this.Controls.Add(this.lblSzallDat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRendeles);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendeles)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvRendeles;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikk_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikk_nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn rend_menny;
        private System.Windows.Forms.DataGridViewTextBoxColumn me;
        private System.Windows.Forms.DataGridViewTextBoxColumn netto_ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn keszlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn netto_ertek;
        private System.Windows.Forms.DataGridViewTextBoxColumn brutto_ertek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSzallDat;
        private System.Windows.Forms.Label lblAzonosito;
        private System.Windows.Forms.Label lblRogzDat;
        private System.Windows.Forms.TextBox txtKintlevo;
        private System.Windows.Forms.TextBox txtSzallDat;
        private System.Windows.Forms.TextBox txtAzonosito;
        private System.Windows.Forms.TextBox txtRogzDat;
        private System.Windows.Forms.Label lblTetelmegjegyzes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSorTorles;
        private System.Windows.Forms.Button btnUjRendeles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtNettoOssz;
        private System.Windows.Forms.TextBox txtBruttoOssz;
        private System.Windows.Forms.Label lblNettoOssz;
        private System.Windows.Forms.Label lblBruttoOssz;
    }
}