using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputOutput.Text += 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double numOne, numTwo, output;
            string input = inputOutput.Text;
            if (input.Contains('x'))
            {
                string[] arr = input.Split('x');
                numOne = double.Parse(arr[0]);
                numTwo = double.Parse(arr[1]);

                output = numOne * numTwo;

                inputOutput.Text = output.ToString();
            }
            if (input.Contains('+'))
            {
                string[] arr = input.Split('+');
                numOne = double.Parse(arr[0]);
                numTwo = double.Parse(arr[1]);

                output = numOne + numTwo;

                inputOutput.Text = output.ToString();
            }
            if (input.Contains('-'))
            {
                string[] arr = input.Split('-');
                numOne = double.Parse(arr[0]);
                numTwo = double.Parse(arr[1]);

                output = numOne - numTwo;

                inputOutput.Text = output.ToString();
            }
            if (input.Contains('/'))
            {
                string[] arr = input.Split('/');
                numOne = double.Parse(arr[0]);
                numTwo = double.Parse(arr[1]);

                output = numOne / numTwo;

                inputOutput.Text = output.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputOutput.Text += 1;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            inputOutput.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputOutput.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputOutput.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputOutput.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputOutput.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputOutput.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputOutput.Text += 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            inputOutput.Text += 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            inputOutput.Text += "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            inputOutput.Text += "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            inputOutput.Text += "x";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            inputOutput.Text += "/";
        }
    }
}
