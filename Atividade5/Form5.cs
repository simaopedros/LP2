using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade5
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void frmExercicio5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtNumero1.Text);
            int numero2 = int.Parse(txtNumero2.Text);

            Random numeroAleatorio = new Random();
            int numAleat = numeroAleatorio.Next(1, 10);

            if (numAleat <= 5)
            {
                MessageBox.Show("Numero Escolhido foi o Primeiro " + txtNumero1.Text);
            }
            else
            {
                MessageBox.Show("Numero escolhido foi o Segundo " + txtNumero2.Text);
            }
        }
    }
}
