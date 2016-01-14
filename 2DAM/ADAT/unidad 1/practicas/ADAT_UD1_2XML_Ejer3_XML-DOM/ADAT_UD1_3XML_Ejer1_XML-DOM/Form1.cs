using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADAT_UD1_3XML_Ejer1_XML_DOM
{

    public partial class Form1 : Form
    {
        List<Libro> libros = new List<Libro>();
        Libro libro;
        FicheroXML fich;
        string celdaSeleccionada;
        public Form1()
        {
            InitializeComponent();
            fich = new FicheroXML("datos.xml");
        }

        public void añadirLibro()
        {
            libro = new Libro(
                this.textBoxCodigo.Text.Trim(),
                this.textBoxIsbn.Text.Trim(),
                this.textBoxTitulo.Text.Trim(),
                this.textBoxAutor.Text.Trim(),
                this.textBoxApellido.Text.Trim(),
                Convert.ToInt32(this.textBoxEjemplares.Text.Trim())
                );
            fich.Añadir(libro);

        }

        //Listeners
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBoxCodigo.Text))
            {
                añadirLibro();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            libros = this.fich.leerNodos();
            dataGridView1.DataSource = libros;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            celdaSeleccionada = libros[e.RowIndex].codigo;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            fich.borrarNodo(celdaSeleccionada);
        }
    }
}
