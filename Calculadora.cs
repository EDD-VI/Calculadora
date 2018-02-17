using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDVI.SoloNumerosYLetras
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        double valor1, valor2, resultado;
        string operacion;

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "1";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "9";
        }

        private void btnOF_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            valor1 = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            valor1 = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            operacion = "x";
            valor1 = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + ".";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operacion = "/";
            valor1 = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(txtPantalla.Text);

            switch (operacion)
            {
                case "-":
                    resultado = valor1 - valor2;
                    txtPantalla.Text = resultado.ToString();
                    break;

                case "+":
                    resultado = valor1 + valor2;
                    txtPantalla.Text = resultado.ToString();
                    break;

                case "x":
                    resultado = valor1 * valor2;
                    txtPantalla.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = valor1 / valor2;
                    txtPantalla.Text = resultado.ToString();
                    break;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "3";
        }
    }
}
