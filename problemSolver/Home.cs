using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problemSolver
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void trignometryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void basicMathToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleCalcualtionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new BasicMaths();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
