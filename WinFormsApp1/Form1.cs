/* *******************************************************************
 * Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 25/05/2023
 * Autores do Projeto: Hiago Valentim Ribeiro
 *                     Gabriel Gonçalves dos Santos
 * Turma: 2I
 * Atividade Proposta em aula
 * Observação: <colocar se houver>
 * 
 * problema_aula.cs
 * ************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int aux = 0;
        int vir = 0;
        string operacao = "";
        double primeiroValor = 0;
        double segundoValor = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void um_Click(object sender, EventArgs e)
        {
            if (aux != 0)
            {
                label1.Text = "1";
                aux = 0;
            }
            else
            {
                label1.Text += "1";
            }

        }

        private void dois_Click(object sender, EventArgs e)
        {
            if (aux != 0)
            {
                label1.Text = "2";
                aux = 0;
            }
            else
            {
                label1.Text += "2";
            }
        }

        private void tres_Click(object sender, EventArgs e)
        {
            if (aux != 0)
            {
                label1.Text = "3";
                aux = 0;
            }
            else
            {
                label1.Text += "3";
            }
        }
        private void quatro_Click(object sender, EventArgs e)
        {
            if (aux != 0)
            {
                label1.Text = "4";
                aux = 0;
            }
            else
            {
                label1.Text += "4";
            }
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            if (aux != 0)
            {
                label1.Text = "5";
                aux = 0;
            }
            else
            {
                label1.Text += "5";
            }
        }

        private void seis_Click(object sender, EventArgs e)
        {
            if (aux != 0)
            {
                label1.Text = "6";
                aux = 0;
            }
            else
            {
                label1.Text += "6";
            }
        }

        private void sete_Click(object sender, EventArgs e)
        {
            if (aux != 0)
            {
                label1.Text = "7";
                aux = 0;
            }
            else
            {
                label1.Text += "7";
            }
        }

        private void oito_Click(object sender, EventArgs e)
        {
            if (aux != 0)
            {
                label1.Text = "8";
                aux = 0;
            }
            else
            {
                label1.Text += "8";
            }
        }

        private void nove_Click(object sender, EventArgs e)
        {
            if (aux != 0)
            {
                label1.Text = "9";
                aux = 0;
            }
            else
            {
                label1.Text += "9";
            }
        }
        private void zero_Click(object sender, EventArgs e)
        {
            if (aux != 0)
            {
                label1.Text = "0";
                aux = 0;
            }
            else
            {
                label1.Text += "0";
            }
        }
        private void button34_Click(object sender, EventArgs e)
        {
            primeiroValor = double.Parse(label1.Text);
            operacao = "+";
            aux = 1;
            vir = 0;
        }
        
        private void igual_Click(object sender, EventArgs e)
        {
            double calculo = 0;
            segundoValor = double.Parse(label1.Text);
            if (operacao == "+")
            {
                calculo = primeiroValor + segundoValor;
                label1.Text = calculo.ToString();
            }
            if (operacao == "-")
            {
                calculo = primeiroValor - segundoValor;
                label1.Text = calculo.ToString();
            }
            if (operacao == "*")
            {
                calculo = primeiroValor * segundoValor;
                label1.Text = calculo.ToString();
            }
            if (operacao == "/")
            {
                if (segundoValor == 0)
                {
                    label1.Text = "não é possível ";
                }
                else
                {
                    calculo = primeiroValor / segundoValor;
                    label1.Text = calculo.ToString();
                }
              
            }
            if (operacao == "raiz")
            {
                calculo = Math.Sqrt(primeiroValor);
                label1.Text = calculo.ToString();
            }
            if (operacao == "quadrado")
            {
                calculo = Math.Pow(primeiroValor,2);
                label1.Text = calculo.ToString();
            }
            if (operacao == "cos")
            {
                primeiroValor = double.Parse(label1.Text);
                calculo = Math.Cos(primeiroValor);
                label1.Text = calculo.ToString();
            }
            if (operacao == "sin")
            {
                primeiroValor = double.Parse(label1.Text);
                calculo = Math.Sin(primeiroValor);
                label1.Text = calculo.ToString();
            }
            if (operacao == "tan")
            {
                primeiroValor = double.Parse(label1.Text);
                calculo = Math.Tan(primeiroValor);
                label1.Text = calculo.ToString();
            }
            if (operacao == "cubo")
            {
                calculo = Math.Pow(primeiroValor, 3);
                label1.Text = calculo.ToString();
            }
            if (operacao == "dezelx")
            {
                primeiroValor = double.Parse(label1.Text);
                calculo = Math.Pow(10, primeiroValor);
                label1.Text = calculo.ToString();
            }
            if (operacao == "log")
            {
                primeiroValor = double.Parse(label1.Text);
                calculo = Math.Log(primeiroValor);
                label1.Text = calculo.ToString();
            }
            if (operacao == "fracao")
            {
                calculo = Math.Pow(primeiroValor,-1);
                label1.Text = calculo.ToString();
            }
            if (operacao == "mod")
            {
                calculo = primeiroValor % segundoValor;
                label1.Text = calculo.ToString();
            }
            if (operacao == "%")
            {
                calculo = (primeiroValor / 100) * segundoValor;
                label1.Text = calculo.ToString();
            }
            if (operacao == "raizcubica")
            {
                calculo = Math.Pow(primeiroValor, 1.0 / 3.0);
                label1.Text = calculo.ToString();
            }
            if (operacao == "fatorial")
            {
                calculo = 1;
                for (int x = 1; x <= primeiroValor; x++)
                {
                    calculo *= x; 
                }
                label1.Text = calculo.ToString();
            }
            if (operacao == "raizqualquer")
            {
                calculo = Math.Pow(primeiroValor, 1.0 / segundoValor);
                label1.Text = calculo.ToString();
            }
            if (operacao == "elevado")
            {
                calculo = Math.Pow(primeiroValor, segundoValor);
                label1.Text = calculo.ToString();
            }
        }

        private void seta_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 1)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1);
            }

            
            else
            {
                label1.Text = ""; 
            }
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            
            if (label1.Text != "" && vir < 1  )
            {
                label1.Text += ",";
                vir++;
            }
            
           
        }

        private void ce_Click(object sender, EventArgs e)
        {
            aux = 0;
            vir = 0;
            operacao = "";
            primeiroValor = 0;
            segundoValor = 0;
            label1.Text = "";

        }


        private void c_Click(object sender, EventArgs e)
        {
         
                label1.Text = "";
            
        }

        private void maisemenos_Click(object sender, EventArgs e)
        {
            primeiroValor = double.Parse(label1.Text);
            primeiroValor *= -1;
            label1.Text = primeiroValor.ToString();
 
        }

        private void button16_Click(object sender, EventArgs e)
        {
            primeiroValor = double.Parse(label1.Text);
            operacao = "elevado";
            aux = 1;
            vir = 0;
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            primeiroValor = double.Parse(label1.Text);
            operacao = "raiz";
            aux = 1;
            vir = 0;
        }

        private void seno_Click(object sender, EventArgs e)
        {

            operacao = "sin";
            aux = 1;
            vir = 0;
        }

        private void quadrado_Click(object sender, EventArgs e)
        {

            operacao = "quadrado";
            primeiroValor = double.Parse(label1.Text);
            aux = 1;
            vir = 0;

        }

        private void fatorial_Click(object sender, EventArgs e)
        {

            operacao = "fatorial";
            primeiroValor = double.Parse(label1.Text);
            aux = 1;
            vir = 0;
        }



        private void divisao_Click(object sender, EventArgs e)
        {

            operacao = "/";
            primeiroValor = double.Parse(label1.Text);
            aux = 1;
            vir = 0;
        }

        private void cosseno_Click(object sender, EventArgs e)
        {
            operacao = "cos";
            aux = 1;
            vir = 0;
        }

        private void raizqual_Click(object sender, EventArgs e)
        {
            primeiroValor = double.Parse(label1.Text);
            operacao = "raizqualquer";
            aux = 1;
            vir = 0;
        }



        private void vezes_Click(object sender, EventArgs e)
        {
            primeiroValor = double.Parse(label1.Text);
            operacao = "*";
            aux = 1;
            vir = 0;
        }

        private void fracao_Click(object sender, EventArgs e)
        {
            primeiroValor = double.Parse(label1.Text);
            operacao = "fracao";
            aux = 1;
            vir = 0;
        }

        private void mod_Click(object sender, EventArgs e)
        {
            primeiroValor = double.Parse(label1.Text);
            operacao = "mod";
            aux = 1;
            vir = 0;
        }

        private void logaritimo_Click(object sender, EventArgs e)
        {

            operacao = "log";
            aux = 1;
            vir = 0;
        }

        private void dezelx_Click(object sender, EventArgs e)
        {
            operacao = "dezelx";
            aux = 1;
            vir = 0;
        }


        private void tangente_Click(object sender, EventArgs e)
        {

            operacao = "tan";
            aux = 1;
            vir = 0;
        }

        private void cubo_Click(object sender, EventArgs e)
        {
            primeiroValor = double.Parse(label1.Text);
            operacao = "cubo";
            aux = 1;
            vir = 0;
        }

        private void raizcubica_Click(object sender, EventArgs e)
        {
            primeiroValor = double.Parse(label1.Text);
            operacao = "raizcubica";
            aux = 1;
            vir = 0;
        }

        private void menos_Click(object sender, EventArgs e)
        {
            primeiroValor = double.Parse(label1.Text);
            operacao = "-";
            aux = 1;
            vir = 0;
        }

        private void porcentagem_Click(object sender, EventArgs e)
        {
            primeiroValor = double.Parse(label1.Text);
            operacao = "%";
            aux = 1;
            vir = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pi_Click(object sender, EventArgs e)
        {
            label1.Text = "3,141592";
            vir = 1;
        }
    }
}
