using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            int c = txtResultado.TextLength;
            int flag = 0;
            string text = txtResultado.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                txtResultado.Text = txtResultado.Text + ".";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                // para fazer operações com .
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            }
            else
            {
                MessageBox.Show("Digite um valor a calcular");
            }
            

            if(operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            } else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIV")
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                // para fazer operações com .
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "SUB";
                
            }
            else
            {
                MessageBox.Show("Digite um valor a calcular");
            }
                        
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                // para fazer operações com .
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "MULT";
                
            }
            else
            {
                MessageBox.Show("Digite um valor a calcular");
            }
                        
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                // para fazer operações com .
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "DIV";
             
            }
            else
            {
                MessageBox.Show("Digite um valor a calcular");
            }
                        
        }
        private void btnApaga_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                // para fazer operações com .
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "SOMA";
         
            }
            else
            {
                MessageBox.Show("Digite um valor a calcular");
            }
        }
    }
}
