using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class FrmWhile : Form
    {
        public FrmWhile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplos_Click(object sender, EventArgs e)
        {
            int multiplos = 3;

            while (multiplos < 99)
            {

                MessageBox.Show("" + multiplos);
                multiplos = multiplos + 3;
            }

        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            float Numeros = 100;

            while (Numeros < 1000)
            {
                MessageBox.Show("" + Numeros);
                Numeros = Numeros + 1;
            }

        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            float aluno = 10;

            while (aluno < 50)
            {
                MessageBox.Show("aluno:" + aluno);
                aluno = aluno + 10;
            }
        }
    }
}