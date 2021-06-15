using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //add numbers into the textbox when num buttons clicked 
        private void btn_num0_Click(object sender, EventArgs e)
        {
            if (txtbox_result.Text == "0")
            {
            }
            else
            {
                txtbox_result.Text += "0";
            }
        }
        private void btn_num1_Click(object sender, EventArgs e)
        {
            if (txtbox_result.Text == "0")
            {
                txtbox_result.Text = "1";
            }
            else
            {
                txtbox_result.Text += "1";
            }
        }
        private void btn_num2_Click(object sender, EventArgs e)
        {
            if (txtbox_result.Text == "0")
            {
                txtbox_result.Text = "2";
            }
            else
            {
                txtbox_result.Text += "2";
            }
        }
        private void btn_num3_Click(object sender, EventArgs e)
        {
            if (txtbox_result.Text == "0")
            {
                txtbox_result.Text = "3";
            }
            else
            {
                txtbox_result.Text += "3";
            }
        }
        private void btn_num4_Click(object sender, EventArgs e)
        {
            if (txtbox_result.Text == "0")
            {
                txtbox_result.Text = "4";
            }
            else
            {
                txtbox_result.Text += "4";
            }
        }
        private void btn_num5_Click(object sender, EventArgs e)
        {
            if (txtbox_result.Text == "0")
            {
                txtbox_result.Text = "5";
            }
            else
            {
                txtbox_result.Text += "5";
            }
        }
        private void btn_num6_Click(object sender, EventArgs e)
        {
            if (txtbox_result.Text == "0")
            {
                txtbox_result.Text = "6";
            }
            else
            {
                txtbox_result.Text += "6";
            }
        }
        private void btn_num7_Click(object sender, EventArgs e)
        {
            if (txtbox_result.Text == "0")
            {
                txtbox_result.Text = "7";
            }
            else
            {
                txtbox_result.Text += "7";
            }
        }
        private void btn_num8_Click(object sender, EventArgs e)
        {
            if (txtbox_result.Text == "0")
            {
                txtbox_result.Text = "8";
            }
            else
            {
                txtbox_result.Text += "8";
            }
        }
        private void btn_num9_Click(object sender, EventArgs e)
        {
            if (txtbox_result.Text == "0")
            {
                txtbox_result.Text = "9";
            }
            else
            {
                txtbox_result.Text += "9";
            }
        }
        private void btn_decimal_Click(object sender, EventArgs e)
        {
            if (txtbox_result.Text.Contains("."))
            {

            }
            else
            {
               txtbox_result.Text += ".";
            }
        }

        //declare variables
        double num1;
        double num2 = 0;
        double result;
        string op = "";

        //operations
        private void btn_add_Click(object sender, EventArgs e)
        {
            
            if (num1 == 0)
            {
                op = "+";
                num1 = double.Parse(txtbox_result.Text);
                txtbox_result.Text = "0";
                label_op.Text = num1.ToString() + op;
            }
            else
            {
                
                num2 = double.Parse(txtbox_result.Text);
                calculate newnum = new calculate(num1, num2, op);
                result = newnum.calculation();
                op = "+";
                label_op.Text = result.ToString() + "+";
                txtbox_result.Text = "0";
                num1 = result;
            }
        }

        private void btn_subtract_Click(object sender, EventArgs e)
        {
           
            if (num1 == 0)
            {
                op = "-";
                num1 = double.Parse(txtbox_result.Text);
                txtbox_result.Text = "0";
                label_op.Text = num1.ToString() + op;
            }
            else
            {
               
                num2 = double.Parse(txtbox_result.Text);
                calculate newnum = new calculate(num1, num2, op);
                result = newnum.calculation();
                op = "-";
                label_op.Text = result.ToString() + "-";
                txtbox_result.Text = "0";
                num1 = result;
            }
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {

            if (num1 == 0)
            {
                op = "*";
                num1 = double.Parse(txtbox_result.Text);
                txtbox_result.Text = "0";
                label_op.Text = num1.ToString() + op;
            }
            else
            {
                num2 = double.Parse(txtbox_result.Text);
                calculate newnum = new calculate(num1, num2, op);
                result = newnum.calculation();
                op = "*";
                label_op.Text = result.ToString() + "*";
                txtbox_result.Text = "0";
                num1 = result;
            }
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            
            if (num1 == 0)
            {
                op = "/";
                num1 = double.Parse(txtbox_result.Text);
                txtbox_result.Text = "0";
                label_op.Text = num1.ToString() + op;
            }
            else
            {
                num2 = double.Parse(txtbox_result.Text);
                calculate newnum = new calculate(num1, num2, op);
                result = newnum.calculation();
                op = "/";
                label_op.Text = result.ToString() + "/";
                txtbox_result.Text = "0";
                num1 = result;
            }
        }

        // equal button
        private void btn_equal_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtbox_result.Text);
            calculate newnum = new calculate(num1, num2, op);
            result = newnum.calculation();
            label_op.Text = num1.ToString() + op + num2.ToString() + "=";
            txtbox_result.Text = result.ToString();

            num1 = 0;
            num2 = 0;
        }
    }
}
