using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DINT_Ejer2._3_Colores
{
    public partial class Colores : Form
    {
        public Colores()
        {
            InitializeComponent();
        }

        private void rbtnAzul_CheckedChanged(object sender, EventArgs e)
        {
            txtColor.BackColor = Color.Blue;
        }

        private void rbtnVerde_CheckedChanged(object sender, EventArgs e)
        {
            txtColor.BackColor = Color.Green;
        }

        private void rbtnRojo_CheckedChanged(object sender, EventArgs e)
        {
            txtColor.BackColor = Color.Red;
        }

        private void rbtnAmarillo_CheckedChanged(object sender, EventArgs e)
        {
            txtColor.BackColor = Color.Yellow;
        }
    }
}
