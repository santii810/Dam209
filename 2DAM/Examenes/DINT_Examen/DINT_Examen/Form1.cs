using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DINT_Examen
{
    public partial class Form1 : Form
    {
        List<Datos> lista;
        public Form1()
        {
            InitializeComponent();
            string fecha;
            DateTime fechaSistema = DateTime.Now;
            fecha = fechaSistema.ToString("d");
            barra.Text = "Fecha actual del sistema: " + fecha;
            lista = new List<Datos>();
            lista.Add(new Datos("Fernandez", "Muñiz", "Juan", "12340670A", "Direccion1"));
            lista.Add(new Datos("Alvares", "Fernandez", "Jose", "123125678A", "Direccion2"));
            lista.Add(new Datos("Muñiz", "Fernandez", "Ana", "12343478A", "Direccion3"));
            lista.Add(new Datos("Alvares", "Alvares", "Maria", "12995678A", "Direccion4"));
            //durante el examen miramos esto y a pesar de que el datagridView contiene los datos, no conseguimos que los mostrase
            dataGridView.DataSource = lista;


        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //esa funcion llama al evento form1_formClosing, en donde ya hay una comprobacion
            //por eso no hago aqui la comprobacion
            this.Close();
        }
        public bool comprobacionSalir()
        {
            return (MessageBox.Show("Seguro que quieres salir?", "Si", MessageBoxButtons.YesNo) == DialogResult.Yes);

            

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!comprobacionSalir())
            {
                e.Cancel = true;
                
            }

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
