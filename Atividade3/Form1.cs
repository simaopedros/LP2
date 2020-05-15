using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double ladoA;
            double laboB;
            double ladoC;

            bool isNumberA;
            bool isNumberB;
            bool isNumberC;

            isNumberA = Double.TryParse(txtA.Text, out ladoA);
            isNumberB = Double.TryParse(txtB.Text, out laboB);
            isNumberC = Double.TryParse(txtC.Text, out ladoC);

            if(isNumberA && isNumberB && isNumberC)
            {
                if ((Math.Abs(laboB-ladoC) < ladoA && ladoA < (laboB+ladoC))||(Math.Abs(ladoA-ladoC)<laboB && laboB < (ladoA+ladoC))||(Math.Abs(ladoA-laboB)<ladoC && ladoC < (ladoA+laboB)))
                {
                    if (ladoA == laboB && ladoA == ladoC)
                    {
                        MessageBox.Show("Triangulo equilatero");
                    }
                    else if (ladoA == laboB || ladoA == ladoC || laboB == ladoC)
                    {
                        MessageBox.Show("Triangulo Isosceles");
                    }
                    else if (ladoA != laboB && ladoA != ladoC && ladoC != laboB)
                    {
                        MessageBox.Show("Triangulo Escaleno");
                    }
                }
                else
                {
                    MessageBox.Show("Não forma um triangulo");
                }
            }
            else
            {
                MessageBox.Show("Existe algum dado errado, com esses valores não é possivel verificar!");
            }
        }
    }
}
