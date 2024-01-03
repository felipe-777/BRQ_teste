using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendPar_Click(object sender, EventArgs e)
        {
            var numero = numPar.Text;

            if(int.TryParse(numero, out int numeroInt))
            {
                if(numeroInt % 2 == 0)
                {
                    MessageBox.Show("O número fornecido é um número par!", "Retorno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O número fornecido não é um número par, tente novamente", "Retorno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Texto fornecido não pode ser convertido para número, favor, tentar novamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
