﻿namespace ukmodul
{
    partial class main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rendelésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekérdezésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korábbiRendeléseimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forgalomVevőreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forgalomTermékreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rendelésToolStripMenuItem,
            this.lekérdezésekToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rendelésToolStripMenuItem
            // 
            this.rendelésToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rendelésToolStripMenuItem.Name = "rendelésToolStripMenuItem";
            this.rendelésToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.rendelésToolStripMenuItem.Text = "Rendelés";
            this.rendelésToolStripMenuItem.Click += new System.EventHandler(this.rendelésToolStripMenuItem_Click);
            // 
            // lekérdezésekToolStripMenuItem
            // 
            this.lekérdezésekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korábbiRendeléseimToolStripMenuItem,
            this.forgalomVevőreToolStripMenuItem,
            this.forgalomTermékreToolStripMenuItem});
            this.lekérdezésekToolStripMenuItem.Name = "lekérdezésekToolStripMenuItem";
            this.lekérdezésekToolStripMenuItem.Size = new System.Drawing.Size(115, 25);
            this.lekérdezésekToolStripMenuItem.Text = "Lekérdezések";
            // 
            // korábbiRendeléseimToolStripMenuItem
            // 
            this.korábbiRendeléseimToolStripMenuItem.Name = "korábbiRendeléseimToolStripMenuItem";
            this.korábbiRendeléseimToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.korábbiRendeléseimToolStripMenuItem.Text = "Korábbi rendeléseim";
            // 
            // forgalomVevőreToolStripMenuItem
            // 
            this.forgalomVevőreToolStripMenuItem.Name = "forgalomVevőreToolStripMenuItem";
            this.forgalomVevőreToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.forgalomVevőreToolStripMenuItem.Text = "Forgalom vevőre";
            // 
            // forgalomTermékreToolStripMenuItem
            // 
            this.forgalomTermékreToolStripMenuItem.Name = "forgalomTermékreToolStripMenuItem";
            this.forgalomTermékreToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.forgalomTermékreToolStripMenuItem.Text = "Forgalom termékre";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 655);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üzletkötői modul";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rendelésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lekérdezésekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korábbiRendeléseimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forgalomVevőreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forgalomTermékreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
    }
}