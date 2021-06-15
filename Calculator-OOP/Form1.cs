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
    }
}
