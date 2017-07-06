using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Calculator
{
    public partial class Form1 : Form
    {
        String operation;
        decimal numberOne;
        decimal numberTwo;
        decimal result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            numberTwo = Convert.ToDecimal(textBox1.Text);
            if (operation == "multiplication") {
                result = numberOne * numberTwo;
                textBox1.Text = Convert.ToString(result);
                
            }
            else if (operation == "dividation") {
                result = numberOne / numberTwo;
                textBox1.Text = Convert.ToString(result);
            }
            else if (operation == "increasing") {
                result = numberOne + numberTwo;
                textBox1.Text = Convert.ToString(result);
            }
            else if (operation == "decreasing") {
                result = numberOne - numberTwo;
                textBox1.Text = Convert.ToString(result);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Convert.ToString(result)) {
                textBox1.Text = "";
            }

            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Convert.ToString(result))
            {
                textBox1.Text = "";
            }

            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Convert.ToString(result))
            {
                textBox1.Text = "";
            }

            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Convert.ToString(result))
            {
                textBox1.Text = "";
            }

            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Convert.ToString(result))
            {
                textBox1.Text = "";
            }

            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Convert.ToString(result))
            {
                textBox1.Text = "";
            }

            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Convert.ToString(result))
            {
                textBox1.Text = "";
            }

            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Convert.ToString(result))
            {
                textBox1.Text = "";
            }

            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Convert.ToString(result))
            {
                textBox1.Text = "";
            }

            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Convert.ToString(result))
            {
                textBox1.Text = "";
            }

            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numberOne = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            operation = "multiplication";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            numberOne = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            operation = "dividation";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            numberOne = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            operation = "increasing";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            numberOne = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            operation = "decreasing";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            decimal removedNumber = Convert.ToDecimal(textBox1.Text);

            int removedNumberLength = textBox1.Text.Length;
            removedNumberLength = removedNumberLength - 1;

            String removedNumberString = Convert.ToString(removedNumber);
            removedNumberString.Remove(removedNumberLength);
            textBox1.Text = removedNumberString;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Convert.ToString(result))
            {
                textBox1.Text = "";
            }

            textBox1.Text += ".";
        }
    }
}
