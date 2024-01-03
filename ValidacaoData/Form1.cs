using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidacaoData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dtNasc = maskedTextBox1.Text;

            if(DateTime.TryParse(dtNasc, out DateTime data))
            {
                if(data < DateTime.Now || data.Year < 2015)
                {
                    int idade = CalculaIdade(data);
                    MessageBox.Show($"Sua idade é {idade} anos");
                }
                else
                {
                    MessageBox.Show($"Insiria uma data válida");
                }
            }
        }

        private int CalculaIdade(DateTime data)
        {
            var idade = DateTime.Now.Year -  data.Year;
            if (DateTime.Now.DayOfYear < data.DayOfYear)
            {
                idade--;
            }

            return idade;
        }
    }
}
