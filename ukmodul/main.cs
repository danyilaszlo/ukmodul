using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukmodul
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void rendelésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rendelesForm rendForm = new rendelesForm();
            rendForm.Show();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
