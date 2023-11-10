using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double total1 = 0;

        double total2 = 0;

        string flag = "";



        private void oneButton_Click(object sender, EventArgs e)

        {

            outputTextBox.Text = outputTextBox.Text + oneButton.Text;

        }

        private void twoButton_Click(object sender, EventArgs e)

        {

            outputTextBox.Text = outputTextBox.Text + twoButton.Text;

        }

        private void threeButton_Click(object sender, EventArgs e)

        {

            outputTextBox.Text = outputTextBox.Text + threeButton.Text;

        }

        private void fourButton_Click(object sender, EventArgs e)

        {

            outputTextBox.Text = outputTextBox.Text + fourButton.Text;

        }

        private void fiveButton_Click(object sender, EventArgs e)

        {

            outputTextBox.Text = outputTextBox.Text + fiveButton.Text;

        }

        private void sixButton_Click(object sender, EventArgs e)

        {

            outputTextBox.Text = outputTextBox.Text + sixButton.Text;

        }

        private void sevenButton_Click(object sender, EventArgs e)

        {

            outputTextBox.Text = outputTextBox.Text + sevenButton.Text;

        }

        private void eightButton_Click(object sender, EventArgs e)

        {

            outputTextBox.Text = outputTextBox.Text + eightButton.Text;
        }

        private void nineButton_Click(object sender, EventArgs e)

        {

            outputTextBox.Text = outputTextBox.Text + nineButton.Text;

        }

        private void zeroButton_Click(object sender, EventArgs e)

        {

            outputTextBox.Text = outputTextBox.Text + zeroButton.Text;

        }

        private void decButton_Click(object sender, EventArgs e)

        {

            outputTextBox.Text = outputTextBox.Text + decButton.Text;

        }

        private void clearButton_Click(object sender, EventArgs e)

        {

            outputTextBox.Clear();

            flag = "";

        }

        private void plusButton_Click(object sender, EventArgs e)

        {

            total1 = total1 + double.Parse(outputTextBox.Text);

            outputTextBox.Clear();

            flag = "+";

        }

        private void equalButton_Click(object sender, EventArgs e)

        {

            total2 = double.Parse(outputTextBox.Text);

            if (flag == "+")

            {

                total2 = total1 + total2;

            }

            else if (flag == "-")

            {

                total2 = total1 - total2;

            }

            else if (flag == "*")

            {

                total2 = total1 * total2;
            }
            else if(flag == "/")
            {
                total2 = total1/total2;
            }
            else if (flag == "^")
            {
                total2 = Math.Pow(total1, total2);
            }

            outputTextBox.Text = total2.ToString();

            total1 = 0;

            total2 = 0;

        }

        private void minusButton_Click(object sender, EventArgs e)

        {

            total1 = total1 + double.Parse(outputTextBox.Text);

            outputTextBox.Clear();

            flag = "-";

        }

        private void mulButton_Click(object sender, EventArgs e)

        {

            total1 = total1 + double.Parse(outputTextBox.Text);

            outputTextBox.Clear();

            flag = "*";

        }

        private void divButton_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(outputTextBox.Text);

            outputTextBox.Clear();

            flag = "/";
        }


        private void ofButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void expButton_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(outputTextBox.Text);
            total1 = Math.Exp(total1);
            outputTextBox.Text = total1.ToString();
            total1 = 0;

        }

        private void powButton_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(outputTextBox.Text);

            outputTextBox.Clear();

            flag = "^";
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(outputTextBox.Text);
            total1 = Math.Log10(total1);
            outputTextBox.Text = total1.ToString();
            total1 = 0;
        }

        private void lnButton_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(outputTextBox.Text);
            total1 = Math.Log(total1);
            outputTextBox.Text = total1.ToString();
            total1 = 0;
        }

        private void sinButton_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(outputTextBox.Text);
            total1 = Math.Sin(total1);
            outputTextBox.Text = total1.ToString();
            total1 = 0;
        }

        private void cosButton_Click(object sender, EventArgs e)
        {

            total1 = total1 + double.Parse(outputTextBox.Text);
            total1 = Math.Cos(total1);
            outputTextBox.Text = total1.ToString();
            total1 = 0;
        }

        private void tanButton_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(outputTextBox.Text);
            total1 = Math.Tan(total1);
            outputTextBox.Text = total1.ToString();
            total1 = 0;

        }

        private void asinButton_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(outputTextBox.Text);
            total1 = Math.Asin(total1);
            outputTextBox.Text = total1.ToString();
            total1 = 0;

        }

        private void acosButton_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(outputTextBox.Text);
            total1 = Math.Acos(total1);
            outputTextBox.Text = total1.ToString();
            total1 = 0;
        }

        private void atanButton_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(outputTextBox.Text);
            total1 = Math.Atan(total1);
            outputTextBox.Text = total1.ToString();
            total1 = 0;

        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(outputTextBox.Text);
            total1 = Math.Sqrt(total1);
            outputTextBox.Text = total1.ToString();
            total1 = 0;
        }

        private void sqrButton_Click(object sender, EventArgs e)
        {

            total1 = total1 + double.Parse(outputTextBox.Text);
            total1 = Math.Pow(total1,2);
            outputTextBox.Text = total1.ToString();
            total1 = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}

