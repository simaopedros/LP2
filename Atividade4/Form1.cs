using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularDesconto_Click(object sender, EventArgs e)
        {
           String nome = txtNome.Text;
           double salarioBruto   = double.Parse(txtSalarioBruto.Text);
           int numeroDeFilhos    = int.Parse(txtNumeroDeFilhos.Text);
            double alicotaInss = 0;
            double alicotaIRPF = 0;
            double salarioFamilia = 0;
            double salarioLiquido = 0;
            double descontoINSS = 0;
            double descontoIRPF = 0;

            //Calculo do INSS
           if(salarioBruto < 800.47)
            {
                alicotaInss = 7.65;
                descontoINSS = salarioBruto * alicotaInss;
            }else if (salarioBruto > 800.47 && salarioBruto < 1050)
            {
                alicotaInss = 8.65;
                descontoINSS = salarioBruto * alicotaInss;
            }
            else if (salarioBruto > 1050.01 && salarioBruto < 1400.77)
            {
                alicotaInss = 9.00;
                descontoINSS = salarioBruto * alicotaInss;
            }
            else if (salarioBruto > 1400.78 && salarioBruto < 2801.56)
            {
                alicotaInss = 11.00;
                descontoINSS = salarioBruto * alicotaInss;
            }
            else
            {
                descontoINSS = 308.17;
            }
            //Calculo do IRPF

            if (salarioBruto < 1250.12)
            {
                alicotaIRPF = 0;
                descontoIRPF = salarioBruto * alicotaIRPF;
            }else if (salarioBruto > 1250.12 && salarioBruto < 2512.08)
            {
                alicotaIRPF = 15.00;
                descontoIRPF = alicotaIRPF * salarioBruto;
            }
            else
            {
                alicotaIRPF = 27.5;
                descontoIRPF = salarioBruto * alicotaIRPF;
            }
           
           //Calculo do Salario Familia

            if(salarioBruto < 435.52)
            {
                salarioFamilia = 22.33 * numeroDeFilhos;
            }else if (salarioBruto < 654.61)
            {
                salarioFamilia = 15.74 * numeroDeFilhos;
            }
            else
            {
                salarioFamilia = 0;
            }

            salarioLiquido = salarioBruto - descontoINSS - descontoIRPF + salarioFamilia;

            txtAlicotaINSS.Text     =   alicotaInss.ToString();
            txtALicotaIRPF.Text     =   alicotaIRPF.ToString();
            txtSalarioFamilia.Text  =   salarioFamilia.ToString();
            txtSalarioLiquido.Text  =   salarioLiquido.ToString();
            txtDescontoINSS.Text    =   descontoINSS.ToString();
            txtDescontoIRPF.Text    =   descontoIRPF.ToString();
            


        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
