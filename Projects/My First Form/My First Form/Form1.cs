using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_First_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sum;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            sum = num1 + num2;
            label3.Text = "Sum is " + sum;
            button1.Text = "Sum Found";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int product;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            product = num1 * num2;
            label4.Text = "Product is " + product;
            button2.Text = "Product Found";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1;
            int num1Cubed;
            num1 = Convert.ToInt32(textBox1.Text);
            num1Cubed = num1 * num1 * num1;
            label5.Text = "Cubed is " + num1Cubed;
            button3.Text = "" + num1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num2;
            int num2Cubed;
            num2 = Convert.ToInt32(textBox2.Text);
            num2Cubed = num2 * num2 * num2;
            label6.Text = "Cubed is " + num2Cubed;
            button4.Text = "" + num2;
        }
    }
}
