using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double renda = double.Parse(this.renda.Text);
            double n1 = double.Parse(energiaTxt.Text);
            double n2 = double.Parse(aguaTxt.Text);
            double n3 = double.Parse(tvTxt.Text);
            double n4 = double.Parse(aliTxt.Text);
            double n5 = double.Parse(outrosTxt.Text);

            double result1 = n1 + n2 + n3 + n4 + n5;

            gastostotal.Text = result1.ToString();

            double result2 = renda - result1 ;

            saldoss.Text = result2.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            renda.Clear();
            energiaTxt.Clear();
            aguaTxt.Clear();
            tvTxt.Clear();
            aliTxt.Clear();

            gastostotal.Text = "0";
            saldoss.Text = "0";

            renda.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
