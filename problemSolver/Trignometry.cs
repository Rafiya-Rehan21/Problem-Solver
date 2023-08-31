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
            txtDisplay.Text += "SIN(";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string expr = txtDisplay.Text;

            int bracketCount1=0;
            int bracketCount2=0;

            List<string> check =new List<string>();
            check.Add(expr);

            foreach(char list in expr)
            {
                if(list=='(')
                {
                   bracketCount1++;
                }
                if(list==')')
                {
                    bracketCount2++; 
                }
            }
            if(bracketCount1!=bracketCount2)
            {
                for(int x=0; x< bracketCount1-bracketCount2;x++)
                {
                    expr += ")";
                }
            }

            if (rbDegree.Checked)
            {
                string str = expr.ToString();
                string extracted = str.Substring('(', ')');
                double radians = Math.PI / 180;
                double Convert = double.Parse(extracted) * radians;

                Expression expressRadians = new Expression(Convert.ToString());
                Object valueForRadians = expressRadians.Eval();
                txtDisplay.Text = valueForRadians.ToString();
            }
            else
            {
                Expression expression = new Expression(expr);
                Object value = expression.Eval();
                txtDisplay.Text = value.ToString();
            } 
        }

        private void Trignometry_Load(object sender, EventArgs e)
        {

        }

        private void btnBracket1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "(";
        }

        private void btnBracket2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ")";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += null;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
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

        private void btnSymbol_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "^";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "+";
        }

        private void btnCosec_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "CSC(";
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "COS(";
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "SEC(";
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "TAN(";
        }

        private void btnCot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "COT(";
        }

        private void rbDegree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "Pi";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "*";
        }
    }
}
