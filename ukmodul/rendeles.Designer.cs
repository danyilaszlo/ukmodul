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
            this.SuspendLayout();
            // 
            // labelKod
            // 
            this.labelKod.AutoSize = true;
            this.labelKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKod.Location = new System.Drawing.Point(43, 43);
            this.labelKod.Name = "labelKod";
            this.labelKod.Size = new System.Drawing.Size(41, 20);
            this.labelKod.TabIndex = 0;
            this.labelKod.Text = "Kód:";
            // 
            // txtKod
            // 
            this.txtKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKod.Location = new System.Drawing.Point(97, 40);
            this.txtKod.Name = "txtKod";
            this.txtKod.ReadOnly = true;
            this.txtKod.Size = new System.Drawing.Size(100, 26);
            this.txtKod.TabIndex = 1;
            // 
            // labelVevonev
            // 
            this.labelVevonev.AutoSize = true;
            this.labelVevonev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVevonev.Location = new System.Drawing.Point(221, 43);
            this.labelVevonev.Name = "labelVevonev";
            this.labelVevonev.Size = new System.Drawing.Size(40, 20);
            this.labelVevonev.TabIndex = 2;
            this.labelVevonev.Text = "Név:";
            // 
            // cmboxVevonev
            // 
            this.cmboxVevonev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxVevonev.FormattingEnabled = true;
            this.cmboxVevonev.Location = new System.Drawing.Point(282, 39);
            this.cmboxVevonev.Name = "cmboxVevonev";
            this.cmboxVevonev.Size = new System.Drawing.Size(198, 28);
            this.cmboxVevonev.TabIndex = 3;
            // 
            // btnVevok
            // 
            this.btnVevok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVevok.Location = new System.Drawing.Point(514, 37);
            this.btnVevok.Name = "btnVevok";
            this.btnVevok.Size = new System.Drawing.Size(76, 30);
            this.btnVevok.TabIndex = 4;
            this.btnVevok.Text = "Vevők...";
            this.btnVevok.UseVisualStyleBackColor = true;
            // 
            // rendelesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 739);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKod;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label labelVevonev;
        private System.Windows.Forms.ComboBox cmboxVevonev;
        private System.Windows.Forms.Button btnVevok;
    }
}