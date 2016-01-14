using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACDA_UD1_3_ahorcado
{
    public partial class FormConfiguracion : Form
    {
        string nombreFich = "palabras.txt";
        ArchivoTexto fichero = new ArchivoTexto();
        public FormConfiguracion()
        {
            InitializeComponent();
        }

        private void botonAdd_Click(object sender, EventArgs e)
        {
            string pal = palabra.Text.ToUpper();
            fichero.agregar(nombreFich, pal);

        }
    }
}
