using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura;
            double pesoAtual;
            String menssagem = "";

            double resultado = 0;

            double.TryParse(txtAltura.Text, out altura);
            double.TryParse(txtPesoAtual.Text, out pesoAtual);

            if (rdbtnMasc.Checked)
            {
                resultado = (72.7 * altura) - 58;
               
            }
            if (rdbtnFem.Checked)
            {
                resultado = (62.1 * altura) - 44.7;
            }

            if (pesoAtual > resultado)
            {
                menssagem = "Regime Obrigatorio";
            }
            if (pesoAtual == resultado)
            {
                menssagem = "Voce esta com o peso ideal";
            }
            if(pesoAtual < resultado)
            {
                menssagem = "Coma bastante massas e doces";
            }
            
            lblResultadoCalculo.Text = menssagem;
        }
    }
}
