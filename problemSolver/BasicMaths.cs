﻿using System;
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
    public partial class BasicMaths : Form
    {
        public BasicMaths()
        {
            InitializeComponent();
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
            txtDisplay.Text = null;
        }

        private void btnBracket3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "[";
        }

        private void btnBracket4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "]";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "x";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
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

        private void btnExponent_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "^";
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "y";
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

        private void btnZ_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "z";
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
            txtDisplay.Text += ",";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btnSymbol1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "%";
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " ";
        }

        private void btnLessThanEqual_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "<=";
        }

        private void btnGreaterEqual_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ">=";
        }

        private void btnOR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "|";
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "!";
        }

        private void btnLessThan_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "<";
        }

        private void btnGreaterThan_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ">";
        }

        private void BasicMaths_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Expression expression = new Expression(txtDisplay.Text);
            Object value = expression.Eval();
            txtDisplay.Text = value.ToString();
        }

        private void btne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "e";
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "Pi";
        }

        private void btnIsEqualTo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "=";
        }
    }
}
