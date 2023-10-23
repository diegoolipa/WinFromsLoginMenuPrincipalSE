namespace CalculadoraBasica
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //txtResultado.Text = "7";
            //txtResultado.Text = txtResultado.Text + "7";
            txtResultado.Text += "7";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "+";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            String dato = txtResultado.Text;
            int resultado = 0;

            if (dato.Contains("+"))
            {
                string[] valores = dato.Split('+');
                foreach (string valor in valores)
                {
                    int numero = int.Parse(valor);
                    resultado += numero;
                }
                txtResultado.Text = resultado.ToString();
            }
            else if (dato.Contains("-"))
            {
                string[] valores = dato.Split("-");
                bool siPorPrimeraVez = true;

                foreach (string valor in valores)
                {
                    if (siPorPrimeraVez == true)
                    {
                        resultado = int.Parse(valor);
                        siPorPrimeraVez = false;
                    }
                    else
                    {
                        int numero = int.Parse(valor);
                        resultado -= numero;
                    }
                }
                txtResultado.Text = resultado.ToString();
            }
            else if (dato.Contains("*"))
            {
                string[] valores = dato.Split("*");
                bool siPorPrimeraVez = true;

                foreach (string valor in valores)
                {
                    if (siPorPrimeraVez == true)
                    {
                        resultado = int.Parse(valor);
                        siPorPrimeraVez = false;
                    }
                    else
                    {
                        int numero = int.Parse(valor);
                        resultado *= numero;
                    }
                }
                txtResultado.Text = resultado.ToString();
            }
            else if (dato.Contains("/"))
            {
                string[] valores = dato.Split("/");
                bool siPorPrimeraVez = true;

                foreach (string valor in valores)
                {
                    if (siPorPrimeraVez == true)
                    {
                        resultado = int.Parse(valor);
                        siPorPrimeraVez = false;
                    }
                    else
                    {
                        int numero = int.Parse(valor);
                        resultado /= numero;
                    }
                }
                txtResultado.Text = resultado.ToString();
            }



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "-";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "*";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "/";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }
    }
}