using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADAT_UD1_2XML_Ej2
{
    public partial class Form1 : Form
    {
        List<Contacto> contactos = new List<Contacto>();
        string nombreFichero = "Agenda.xml";
        List<string> lineasFichero = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Ficheros xml | *.xml";
            ofd.OpenFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contacto tmp = new Contacto();
            tmp.nombre = textBoxNombre.Text;
            tmp.apellido = textBoxApellido.Text;
            tmp.direccion = textBoxDireccion.Text;
            tmp.tlfCasa = textBoxTlfCasa.Text;
            tmp.tlfTrabajo = textBoxTlfTrabajo.Text;
            tmp.tlfMovil = textBoxTlfMovil.Text;
            contactos.Add(tmp);
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxDireccion.Clear();
            textBoxTlfCasa.Clear();
            textBoxTlfTrabajo.Clear();
            textBoxTlfMovil.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxXml.Clear();
            //Esta parte no me funciona, Lo subo asi por que no encontramos el error
            dataGridView1.DataSource = contactos;
            Fichero fich = new Fichero();
            lineasFichero = fich.LeerLinea(nombreFichero);
            foreach (string item in fich.LeerLinea(nombreFichero))
            {
                textBoxXml.Text = textBoxXml.Text + "\r\n" + item;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FicheroXML fichXML = new FicheroXML();
            fichXML.escribirXMl(nombreFichero, contactos);

        }
    }
}
