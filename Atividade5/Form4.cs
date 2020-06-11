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
    public partial class formExercicio4 : Form
    {
        public formExercicio4()
        {
            InitializeComponent();
        }

        private void formExercicio4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContaNumero_Click(object sender, EventArgs e)
        {
            int qtdNumero;            
            String texto = txtTextos.Text;
            int tamanho = texto.Count();
            MessageBox.Show(tamanho.ToString());

            for (int i = 0; i < tamanho; i++)
            {
                if (isNu)
            }
        }
    }
}
