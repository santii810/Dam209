using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
namespace examen_EV1_P1
{
    public partial class Form1 : Form
    {
     GestorXML gxml = new GestorXML();
     List<Modulo> modulos = new List<Modulo>();
     List<Alumno> listaAlu = new List<Alumno>();
        public Form1()
        {
            
            InitializeComponent();
            modulos = gxml.cargaModulos(); 
            dataGridView2.DataSource = modulos;
            comboBox1.DataSource = modulos;
            comboBox1.DisplayMember = "Nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listaAlu = gxml.consultaNotas(comboBox1.SelectedIndex + 1, modulos[comboBox1.SelectedIndex].nombre, modulos[comboBox1.SelectedIndex].horasTotales);
            dataGridView1.DataSource = listaAlu;
        }
    
        private void button3_Click(object sender, EventArgs e)
        {if (listaAlu.Count()>0) gxml.crearXml(listaAlu,modulos[comboBox1.SelectedIndex ].nombre+".xml");
           
        }

      
    }
}
