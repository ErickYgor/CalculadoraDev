using System.Globalization;

namespace CalculadoraDev
{
    public partial class Form1 : Form
    {

        string numeroUmTexto, numeroDoisTexto, sinal;
        bool separadorNumero;
        double numeroUm, numeroDois;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblVisor.Text += 1;
            if (!separadorNumero)
                numeroUmTexto = lblVisor.Text;
            else
                numeroDoisTexto += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblVisor.Text += 2;
            if (!separadorNumero)
                numeroUmTexto = lblVisor.Text;
            else
                numeroDoisTexto += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblVisor.Text += 3;
            if (!separadorNumero)
                numeroUmTexto = lblVisor.Text;
            else
                numeroDoisTexto += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblVisor.Text += 4;
            if (!separadorNumero)
                numeroUmTexto = lblVisor.Text;
            else
                numeroDoisTexto += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblVisor.Text += 5;
            if (!separadorNumero)
                numeroUmTexto = lblVisor.Text;
            else
                numeroDoisTexto += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblVisor.Text += 6;
            if (!separadorNumero)
                numeroUmTexto = lblVisor.Text;
            else
                numeroDoisTexto += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblVisor.Text += 7;
            if (!separadorNumero)
                numeroUmTexto = lblVisor.Text;
            else
                numeroDoisTexto += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblVisor.Text += 8;
            if (!separadorNumero)
                numeroUmTexto = lblVisor.Text;
            else
                numeroDoisTexto += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblVisor.Text += 9;
            if (!separadorNumero)
                numeroUmTexto = lblVisor.Text;
            else
                numeroDoisTexto += 9;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            lblVisor.Text += 0;
            if (!separadorNumero)
                numeroUmTexto = lblVisor.Text;
            else
                numeroDoisTexto += 0;
        }

        private void btnVirgula_Click_1(object sender, EventArgs e)
        {
            lblVisor.Text += ",";
            if (!separadorNumero)
                numeroUmTexto += ",";
            else
                numeroDoisTexto += ",";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (separadorNumero == false)
            {
                sinal = "+";
                lblVisor.Text += " + ";
                separadorNumero = true;
            }

            else if (numeroDoisTexto != "")
            {
                btnIgual_Click(sender, e);
                sinal = "+";
                lblVisor.Text = numeroUmTexto + " + ";
                numeroDoisTexto = "";
                separadorNumero = true;
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (separadorNumero == false)
            {
                sinal = "-";
                lblVisor.Text += " - ";
                separadorNumero = true;
            }

            else if (numeroDoisTexto != "")
            {
                btnIgual_Click(sender, e);
                sinal = "-";
                lblVisor.Text = numeroUmTexto + " - ";
                numeroDoisTexto = "";
                separadorNumero = true;
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (separadorNumero == false)
            {
                sinal = "*";
                lblVisor.Text += " x ";
                separadorNumero = true;
            }

            else if (numeroDoisTexto != "")
            {
                btnIgual_Click(sender, e);
                sinal = "*";
                lblVisor.Text = numeroUmTexto + " x ";
                numeroDoisTexto = "";
                separadorNumero = true;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (separadorNumero == false)
            {
                sinal = "/";
                lblVisor.Text += " / ";
                separadorNumero = true;
            }

            else if (numeroDoisTexto != "")
            {
                btnIgual_Click(sender, e);
                sinal = "/";
                lblVisor.Text = numeroUmTexto + " / ";
                numeroDoisTexto = "";
                separadorNumero = true;
            }
        }

        private void btnTrocaSinal_Click(object sender, EventArgs e)
        {

            if (!separadorNumero)
            {
                double numTroca = double.Parse(numeroUmTexto, CultureInfo.GetCultureInfo("pt-BR"));
                numTroca *= -1;
                numeroUmTexto = numTroca.ToString();
                lblVisor.Text = numeroUmTexto;
            }
            else
            {
                double numTroca = double.Parse(numeroDoisTexto, CultureInfo.GetCultureInfo("pt-BR"));
                numTroca *= -1;
                numeroDoisTexto = numTroca.ToString();
                lblVisor.Text = numeroDoisTexto;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(numeroUmTexto) &&
                !string.IsNullOrWhiteSpace(numeroDoisTexto) &&
                !string.IsNullOrWhiteSpace(sinal))
            {
                numeroUm = double.Parse(numeroUmTexto, CultureInfo.GetCultureInfo("pt-BR"));
                numeroDois = double.Parse(numeroDoisTexto, CultureInfo.GetCultureInfo("pt-BR"));

                switch (sinal)
                {
                    case "+":
                        numeroUm = numeroUm + numeroDois;
                        lblVisor.Text = numeroUm.ToString();
                        break;
                    case "-":
                        numeroUm = numeroUm - numeroDois;
                        lblVisor.Text = numeroUm.ToString();
                        break;
                    case "*":
                        numeroUm = numeroUm * numeroDois;
                        lblVisor.Text = numeroUm.ToString();
                        break;
                    case "/":
                        if (numeroDois != 0)
                        {
                            numeroUm = numeroUm / numeroDois;
                            lblVisor.Text = numeroUm.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Acho que alguém tem que ter aulas de matemática.");
                        }
                        break;
                }

                separadorNumero = false;
                numeroUmTexto = lblVisor.Text;
                numeroDoisTexto = "";
            }
        }

        private void btnApagarVisor_Click(object sender, EventArgs e)
        {
            separadorNumero = false;
            sinal = "";
            numeroUmTexto = "";
            numeroDoisTexto = "";
            lblVisor.Text = "";
        }

        private void btnApagarEntrada_Click(object sender, EventArgs e)
        {
            if (separadorNumero == false)
            {
                numeroUmTexto = "";
                lblVisor.Text = "";
            }
            else
            {
                numeroDoisTexto = "";
                lblVisor.Text = numeroUmTexto + " " + sinal + " ";
            }
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            this.Hide();
            sobre.Show();
        }
    }
}

