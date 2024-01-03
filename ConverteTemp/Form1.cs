using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace ConverteTemp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var c = textBox1.Text;

            if(Double.TryParse(c, NumberStyles.Any, CultureInfo.InvariantCulture, out double temp))
            {
                double kelvin = temp + 273.15;

                MessageBox.Show($"A temperatura em Kelvin é de {kelvin}k");
            }
            else
            {
                MessageBox.Show("Por favor insira um número válido, com casas decimais separadas por '.' ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fahrenheitBtt_Click(object sender, EventArgs e)
        {
            var c = textBox1.Text;

            if (Double.TryParse(c, NumberStyles.Any, CultureInfo.InvariantCulture, out double temp))
            {
                double fahrenheit = ((temp - 32) * 5) / 9;

                MessageBox.Show($"A temperatura em Fahrenheit é de {fahrenheit}f");
            }
            else
            {
                MessageBox.Show("Por favor insira um número válido, com casas decimais separadas por '.' ");
            }
        }
    }
}
