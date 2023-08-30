using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.matheval;

namespace problemSolver
{
    public partial class Trignometry : Form
    {
        public Trignometry()
        {
            InitializeComponent();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "sin";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "90";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string expr = txtDisplay.Text;

            Expression expression = new Expression("SIN((90) * Pi/180)");
            Object value = expression.Eval();
            txtDisplay.Text = value.ToString();
        }
    }
}
