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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column6,
            this.Column7});
            this.dgviewRendeles.Location = new System.Drawing.Point(12, 134);
            this.dgviewRendeles.Name = "dgviewRendeles";
            this.dgviewRendeles.Size = new System.Drawing.Size(1247, 526);
            this.dgviewRendeles.TabIndex = 7;
            this.dgviewRendeles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgviewRendeles_KeyDown);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 41.15464F;
            this.Column1.HeaderText = "Cikkszám";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 355.3299F;
            this.Column2.HeaderText = "Termék neve";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 60.70308F;
            this.Column3.HeaderText = "Mennyiség";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 60.70308F;
            this.Column4.HeaderText = "ME";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 60.70308F;
            this.Column5.HeaderText = "Egységár";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Készlet";
            this.Column8.Name = "Column8";
            // 
            // Column6
            // 
            this.Column6.FillWeight = 60.70308F;
            this.Column6.HeaderText = "Nettó érték";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 60.70308F;
            this.Column7.HeaderText = "Bruttó érték";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(617, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Keresés eredménye: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(614, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datagridview-ból a keresett string: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(618, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Talált rekord db: ";
            // 
            // rendelesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 739);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}