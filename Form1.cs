using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryReservasLopez
{
    public partial class frmTeatros : Form
    {
        public frmTeatros()
        {
            InitializeComponent();
        }

        private void quenakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuenaken frmQuenaken = new frmQuenaken();    
            frmQuenaken.ShowDialog();
        }

        private void onasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOnas frmOnas = new frmOnas();
            frmOnas.Show();
            this.Dispose(true);
        }

        private void tobasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTobas frmTobas = new frmTobas();
            frmTobas.Show();
            this.Dispose();
        }
    }
}
