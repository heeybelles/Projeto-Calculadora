using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalcular
{
    public partial class Form1 : Form
    {
        string op; double a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void number5_Click(object sender, EventArgs e)
        {

            txtTexto.Text += "5";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void number1_Click(object sender, EventArgs e)
        {
            txtTexto.Text += "1";
        }

        private void number2_Click(object sender, EventArgs e)
        {

            txtTexto.Text += "2";
        }

        private void number3_Click(object sender, EventArgs e)
        {

            txtTexto.Text += "3";
        }

        private void number4_Click(object sender, EventArgs e)
        {

            txtTexto.Text += "4";
        }

        private void number6_Click(object sender, EventArgs e)
        {

            txtTexto.Text += "6";
        }

        private void number7_Click(object sender, EventArgs e)
        {

            txtTexto.Text += "7";
        }

        private void number8_Click(object sender, EventArgs e)
        {

            txtTexto.Text += "8";
        }

        private void number9_Click(object sender, EventArgs e)
        {

            txtTexto.Text += "9";
        }

        private void number0_Click(object sender, EventArgs e)
        {

            txtTexto.Text += "0";
        }

        private void numberDec_Click(object sender, EventArgs e)
        {

            txtTexto.Text += ",";
            

        }

        private void adicaoNumber_Click(object sender, EventArgs e)
        {
            op = "+";

            a = double.Parse(txtTexto.Text);
            txtTexto.Text = "";


        }

        private void multNumber_Click(object sender, EventArgs e)
        {
            op = "*";
            a = double.Parse(txtTexto.Text);
            txtTexto.Text = "";
        }

        private void dividirNumber_Click(object sender, EventArgs e)
        {
            op = "/";
            a = double.Parse(txtTexto.Text);
            txtTexto.Text = "";
        }

        private void subnumber_Click(object sender, EventArgs e)
        {
            op = "-";
            a = double.Parse(txtTexto.Text);
            txtTexto.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            b = double.Parse(txtTexto.Text);
            
            if (op== "+")txtTexto.Text=(a+b).ToString();
            if (op == "-") txtTexto.Text = (a - b).ToString();
            if (op == "*") txtTexto.Text = (a * b).ToString();
            if (op == "/") txtTexto.Text = (a / b).ToString();
        }
    }
}
