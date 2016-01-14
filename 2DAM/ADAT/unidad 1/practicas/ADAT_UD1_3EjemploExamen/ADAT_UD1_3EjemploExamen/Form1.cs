using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADAT_UD1_3EjemploExamen
{
    public partial class Form1 : Form
    {
        Fichero fichero;
        FicheroXML xml;
        string rutaFichero = "modulos.txt";
        string rutaXML = "Faltas.xml";
        Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();
        List<Modulo> modulos = new List<Modulo>();

        Modulo moduloSeleccionado;
      

        public Form1()
        {
            InitializeComponent();

            //leer modulos

           
        }


        public void mostrarModulosEntrada()
        {
            fichero = new Fichero();
            foreach (string item in fichero.LeerLineas(rutaFichero))
            {
                string[] split = item.Split('\t');
                modulos.Add(new Modulo
                {
                    Id = Convert.ToInt32(split[0]),
                    Nombre = split[1],
                    horasTotales = Convert.ToInt32(split[2])
                });
            }
            dataGridViewEntrada.DataSource = modulos;
        }
        public void mostrarAlumnosEntrada()
        {
            xml = new FicheroXML(rutaXML);
            alumnos = xml.leerAlumnos();
            this.dataGridViewEntrada.DataSource = alumnos.Values.ToList<Alumno>();
        }
        public void mostrarAlumnosSalida(DataGridViewCellEventArgs e)
        {
            int idModulo = Convert.ToInt32(dataGridViewEntrada[0, e.RowIndex].Value.ToString());
            foreach (Modulo item in modulos)
            {
                if (item.Id == idModulo)
                {
                    moduloSeleccionado = item;
                }
            }
            xml = new FicheroXML(rutaXML);
            alumnos = xml.leerFaltasModulo(moduloSeleccionado.Id, moduloSeleccionado.horasTotales, moduloSeleccionado.Nombre);
            this.dataGridViewSalida.DataSource = alumnos.Values.ToList<Alumno>();
            xml.añadir(alumnos.Values.ToList<Alumno>());
        }
        public void mostrarModulosSalida(DataGridViewCellEventArgs e)
        {
            int idAlumno = Convert.ToInt32(dataGridViewEntrada[0, e.RowIndex].Value.ToString());
        }

        private void dataGridViewModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    mostrarAlumnosSalida(e);
                    break;
                case 1:
                    mostrarModulosSalida(e);
                    break;
                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    mostrarModulosEntrada();
                    break;
                case 1:
                    mostrarAlumnosEntrada();
                    break;
                default:
                    break;
            }
        }
    }
}
