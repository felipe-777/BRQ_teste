using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = textBox1.Text;

            List<string> tipoNum = Converter(lista);
            var retorno = "";

            foreach(string i in tipoNum)
            {
                retorno += i + ", ";
            }
            MessageBox.Show(retorno);
        }

        private List<string> Converter(string lista)
        {
            List<string> tipoNum = new List<string>();

            string[] numeros = lista.Split(',');

            foreach(var num in numeros)
            {
                if (int.TryParse(num, out int v))
                {
                    string result = v >= 0 ? "POSITIVO" : "NEGATIVO";

                    tipoNum.Add(result);
                }
            }

            return tipoNum;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
