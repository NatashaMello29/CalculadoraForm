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
            // Implementar depois...
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


                // Obter o botão que está chamando esse evento:
                Button botaoClicado = (Button)sender;

                // Adicionar o Text do botão clicado no TextBox:
                txbTela.Text += botaoClicado.Text;

                // Mudar o operador_Clicado pra true: (levantar a bandeirinha)
                operador_Clicado = true;
            }

        }

    }
}
