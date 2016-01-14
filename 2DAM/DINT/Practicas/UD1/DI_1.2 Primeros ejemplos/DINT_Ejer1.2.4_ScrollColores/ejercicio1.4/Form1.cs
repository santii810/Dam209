using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nudRojo_ValueChanged(object sender, EventArgs e)
        {
            txtTitulo.BackColor =  Color.FromArgb(Decimal.ToInt32(nudRojo.Value), Decimal.ToInt32(nudVerde.Value), Decimal.ToInt32(nudAzul.Value));

        }

        private void nudVerde_ValueChanged(object sender, EventArgs e)
        {
            txtTitulo.BackColor = Color.FromArgb(Decimal.ToInt32(nudRojo.Value), Decimal.ToInt32(nudVerde.Value), Decimal.ToInt32(nudAzul.Value));

        }

        private void nudAzul_ValueChanged(object sender, EventArgs e)
        {
            txtTitulo.BackColor = Color.FromArgb(Decimal.ToInt32(nudRojo.Value), Decimal.ToInt32(nudVerde.Value), Decimal.ToInt32(nudAzul.Value));

        }
    }
}
