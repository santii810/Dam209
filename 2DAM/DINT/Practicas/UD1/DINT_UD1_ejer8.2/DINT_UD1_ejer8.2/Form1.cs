using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DINT_UD1_ejer8._2
{
    public partial class Form1 : Form
    {
        char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M',
            'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J',
            'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Count() > 8)
            {
                e.Handled = true;
            }
            if (textBox1.Text.Count() != 8)
            {
                if (!Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
            else
            {
                if (!Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Count() > 8)
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = textBox1.Text.Substring(0, 8);
            int num = Convert.ToInt32(cadena);
            if (textBox1.Text.ElementAt<char>(8) == letras[num%23])
            {
                MessageBox.Show("DNI correcto");
            }else
            {
                errorProvider1.SetError(this.textBox1, "DNI incorrecto");
            }

        }
    }
}
