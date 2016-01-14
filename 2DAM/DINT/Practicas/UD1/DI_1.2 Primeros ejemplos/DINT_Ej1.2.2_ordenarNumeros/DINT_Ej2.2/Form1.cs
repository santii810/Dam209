using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DINT_Ej2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            txtLista.Text = txtLista.Text + " " + txtNumero.Text;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (rbtnAscendente.Checked == true || rbtnDescendente.Checked == true)
            {

                string[] strLista = txtLista.Text.Split(' ');
                int[] lista = new int[strLista.Length];
                for (int i = 0; i < strLista.Length; i++)
                {
                    if (strLista[i] != "")
                        lista[i] = int.Parse(strLista[i]);
                }
                if (rbtnAscendente.Checked == true)
                    Array.Sort(lista);
                else if (rbtnDescendente.Checked == true)
                    Array.Reverse(lista);
                txtLista.Text = "";
                foreach (int item in lista)
                {
                    if (item !=0)
                    txtLista.Text = txtLista.Text + " " + item;
                }
            }
        }

        private void btnListaNueva_Click(object sender, EventArgs e)
        {
            txtLista.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
