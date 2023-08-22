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
using problemSolver.BL;
namespace problemSolver
{
    public partial class Area_VolumeCalculations : Form
    {
        public Area_VolumeCalculations()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "(";
        }

        private void Area_VolumeCalculations_Load(object sender, EventArgs e)
        {
            lblInput1.Hide();
            lblInput2.Hide(); 
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btnBracket2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ")";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = null;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "^2";
        }

        private void btnIsEqualTo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "=";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "*";
        }

        private void btnExponenet_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "^";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "/";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "+";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "-";
        }

        private void btnSqRoot_Click(object sender, EventArgs e)
        {

        }

        private void btnPowerMultiply_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "*10^";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "%";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string expr = txtDisplay.Text;

            expr = expr.Replace("%", "/100");

            //  Expression expression = new Expression(expr);
            //  Object value = expression.Eval();
            //  txtDisplay.Text = value.ToString();

            if (cbxShape.SelectedItem.ToString() == "Triangle")
            {
                lblInput1.Show();
                lblInput2.Show();
                lblInput1.Text = "Base: ";
                lblInput2.Text = "Height: ";
            }

        }
    }
}
