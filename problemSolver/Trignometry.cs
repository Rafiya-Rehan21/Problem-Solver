using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.matheval;

namespace problemSolver
{
    public partial class Trignometry : Form
    {
        //Regex funcRX = new Regex(@"(?:SIN|COS|TAN|COSEC|CSC|SEC|COT)\([0-9]*[+\-*\/\^](?R)?\)"); // not supported by C#, emulated in getTrigFunctions
        List<string> trigFuncNames = new List<string>() { "SIN", "COS", "TAN", "COSEC", "CSC", "SEC", "TAN" };

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

        private string getAngle(string line)
        {
            string angle = "";
            int openBrackets = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '(')
                    openBrackets++;
                else if (line[i] == ')')
                    openBrackets--;

                if (openBrackets > 0)
                {
                    if (line[i] != '(' || openBrackets != 1)
                        angle += line[i];
                }
            }

            return angle;
        }

        private string getTrigFunction(int startIdx, string line)
        {
            string extracted = "";
            string str = line.Substring(startIdx);

            foreach (string func in trigFuncNames)
            {
                int idx = str.IndexOf(func);

                if (idx == 0)
                {
                    if (str[idx + func.Length] == '(')
                    {
                        extracted = func + '(';
                        bool arithmeticSymbolFound = false;

                        for (int i = idx + func.Length + 1; i < str.Length; i++)
                        {
                            char c = str[i];

                            if (c >= '0' && c <= '9')
                            {
                                extracted += c;
                            }
                            else if ((c == '+' || c == '-' || c == '*' || c == '/' || c == '^') && !arithmeticSymbolFound)
                            {
                                extracted += c;
                                arithmeticSymbolFound = true;
                            }
                            else
                            {
                                extracted += getTrigFunction(i, str);

                                break;
                            }
                        }

                        if (str[idx + extracted.Length] != ')')
                            return "";

                        extracted += ')';
                        break;
                    }
                }
                    
            }

            return extracted;
        }

        private List<string> getTrigFunctions(string line)
        {
            int idx = 0;
            List<string> functions = new List<string>();

            while (idx < line.Length)
            {
                string func = getTrigFunction(idx, line);

                if (func != "")
                {
                    functions.Add(func);
                    idx += func.Length;
                }
                else
                {
                    idx++;
                }
            }

            functions = functions.Distinct().ToList();

            return functions;
        }

        private string convertAnglesToRadians(string line)
        {
            string converted = line;
            List<string> funcs = getTrigFunctions(line);

            foreach (string func in funcs)
            {
                string angle = getAngle(func);
                int idx = func.IndexOf(angle);

                string convertedFunc = func.Substring(0, idx) + "RADIANS(" + convertAnglesToRadians(angle) + ')' + func.Substring(idx + angle.Length);
                converted = converted.Replace(func, convertedFunc);
            }

            return converted;
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
                expr = convertAnglesToRadians(expr);
            }

            Expression expressRadians = new Expression(expr);
            Object valueForRadians = expressRadians.Eval();
            txtDisplay.Text = valueForRadians.ToString();
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
