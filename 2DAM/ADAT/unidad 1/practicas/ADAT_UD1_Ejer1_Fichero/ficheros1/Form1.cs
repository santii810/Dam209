using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ficheros1
{
    public partial class Form1 : Form
    {


        ArrayList frases = new ArrayList();
        Fichero fich = new Fichero();
        int posListBox = 0;

        public Form1()
        {
            InitializeComponent();
            lblPagina.Text = "Página " + (posListBox + 1).ToString();
        }

        private void addToListBox(ArrayList list)
        {
            try
            {
                int rango = list.Count - posListBox * 10;
                if (rango > 10)
                    rango = 10;
                foreach (Frases item in list.GetRange(posListBox * 10, rango))
                {
                    lbFrases.Items.Add(item.Autor + ": \t" + item.Frase);
                }
            }
            catch { }


        }
        private void leerDatos()
        {
            frases.Clear();
            ArrayList lineas = new ArrayList(fich.LeerLinea(tbNombreArchivo.Text));

            foreach (string item in lineas)
            {
                frases.Add(new Frases(item));
            }
        }








        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Text Files (.txt)|*.txt";
            dialogo.ShowDialog();
            tbNombreArchivo.Text = dialogo.FileName;
            leerDatos();

        }

        private void btnVerFrases_Click(object sender, EventArgs e)
        {

            lbFrases.Items.Clear();
            leerDatos();
            addToListBox(frases);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lbFrases.Items.Clear();
            ArrayList lista = new ArrayList();
            foreach (Frases item in frases)
            {
                if (item.Autor.ToLower() == tbBuscar.Text.ToLower())
                    lista.Add(item);
            }
            if (lista.Count == 0)

                lbFrases.Items.Add("No hay coincidencias en la busqueda");
            else
                addToListBox(lista);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            fich.agregar(tbNombreArchivo.Text, nuevaFrase.Text + " - " + nuevoAutor.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (posListBox != 0)
                posListBox--;
            lbFrases.Items.Clear();
            addToListBox(frases);
            lblPagina.Text = "Página " + (posListBox + 1).ToString();
        }

        private void btnSiguientes_Click(object sender, EventArgs e)
        {
            posListBox++;
            lbFrases.Items.Clear();
            addToListBox(frases);
            lblPagina.Text = "Página " + (posListBox + 1).ToString() ;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

