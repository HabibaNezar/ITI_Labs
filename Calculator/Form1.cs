using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double firstNumber = 0;
        double secondNumber = 0;
        string operation = "";
        double result = 0;
        public Calculator()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

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

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "+";
            txtDisplay.Clear();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "-";
            txtDisplay.Clear();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "*";
            txtDisplay.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "/";
            txtDisplay.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Clear();
            if (operation == "/" && secondNumber == 0)
            {
                MessageBox.Show("Cannot divide by zero");
                return;
            }
            if (operation == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if(operation == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if(operation == "*")
            {
                result = firstNumber * secondNumber;
            }
            else
            {
                result = firstNumber / secondNumber;
            }
            txtDisplay.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }
    }
}
