using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForm
{
    public partial class form1 : Form
    {

        // Variáveis globais:
        bool operador_Clicado = true;

        public form1()
        {
            InitializeComponent();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string texto = txbTela.Text;
            string ultimoChar = texto.Length > 0 ? texto[texto.Length - 1].ToString() : "";
            
            if (texto != "" && ultimoChar != "+" && ultimoChar != "-" && ultimoChar != "*" && ultimoChar != "/")
            {
                // Calcular a expressao:
                txbTela.Text = new System.Data.DataTable().Compute(txbTela.Text, null).ToString();
                if (txbTela.Text == "∞")
                {
                    MessageBox.Show("Erro");
                }

                // Abaixar a bandeirinha:
                operador_Clicado = false;


            }
            else
            {
                // Mostrar erro na tela:
                MessageBox.Show("erro");
                // Levantar a bandeirinha:
                operador_Clicado = true;
            }

        }

        private void numero_Click(object sender, EventArgs e)
        {
            // Obter o botão que está chamando esse evento:
            Button botaoClicado = (Button)sender;

            // Adicionar o Text do botão clicado no TextBox:
            txbTela.Text += botaoClicado.Text;

            // "abaixar a bandeirinha"
            operador_Clicado = false;
        }

        private void operador_Click(object sender, EventArgs e)
        {
            // Verificar se o operador ainda não foi clicado:
            if (operador_Clicado == false)
            {

                if (txbTela.Text == "Erro")
                    return;
                // Obter o botão que está chamando esse evento:
                Button botaoClicado = (Button)sender;

                // Adicionar o Text do botão clicado no TextBox:
                txbTela.Text += botaoClicado.Text;

                // Mudar o operador_Clicado pra true: (levantar a bandeirinha)
                operador_Clicado = true;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar a tela:
            txbTela.Text = "";
            // Voltar o operador clicado para true:
            operador_Clicado = true;
        }
    }
}
