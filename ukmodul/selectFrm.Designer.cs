namespace ukmodul
{
    partial class selectCikkForm
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
            this.dgvCikkSelect = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCikkSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCikkSelect
            // 
            this.dgvCikkSelect.AllowUserToAddRows = false;
            this.dgvCikkSelect.AllowUserToDeleteRows = false;
            this.dgvCikkSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCikkSelect.Location = new System.Drawing.Point(0, 0);
            this.dgvCikkSelect.Name = "dgvCikkSelect";
            this.dgvCikkSelect.ReadOnly = true;
            this.dgvCikkSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCikkSelect.Size = new System.Drawing.Size(707, 347);
            this.dgvCikkSelect.TabIndex = 0;
            // 
            // selectCikkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 347);
            this.Controls.Add(this.dgvCikkSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "selectCikkForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Válassz terméket...";
            this.Load += new System.EventHandler(this.selectCikkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCikkSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCikkSelect;
    }
}