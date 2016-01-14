using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADAT_UD1_Ejer3_Test
{
    public partial class Form1 : Form
    {
        Dictionary<int, char> respuestasCorrectas = new Dictionary<int, char>();
        Dictionary<int, char> respuestas = new Dictionary<int, char>();
        List<Alumno> alumnos = new List<Alumno>(); 

        public Form1()
        {
            InitializeComponent();
            string nombreFicheroRespuestas = @"plantilla.txt";
            string nombreFicheroExamen = @"datos.txt";
            Fichero fich = new Fichero();
            int preguntasTotales = 0;
            string nombreAlumno = "";

            //leer plantilla
            foreach (string item in fich.LeerLinea(nombreFicheroRespuestas))
            {
                string[] linea = item.Split('-');
                int num = Convert.ToInt32(Convert.ToInt32(linea[0]));
                char resp = linea[1].ElementAt<char>(0);
                respuestasCorrectas.Add(num, resp);
                preguntasTotales++;
            }
            //leer examenes
            foreach (string item in fich.LeerLinea(nombreFicheroExamen))
            {
                string[] linea = item.Split('-');
                if (linea.Length == 1)
                {
                    if (!nombreAlumno.Equals(""))
                        alumnos.Add(new Alumno(nombreAlumno, respuestas, respuestasCorrectas, preguntasTotales));
                    respuestas.Clear();
                    nombreAlumno = linea[0];
                }
                else
                {
                    int num = Convert.ToInt32(linea[0]);
                    respuestas.Add(num, linea[1].ElementAt<char>(0));
                }
            }
            foreach (Alumno item in alumnos)
            {
                listBox1.Items.Add(item.nombre);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Alumno item in alumnos)
            {
                if (item.nombre.Equals((string)listBox1.SelectedItem))
                {
                    mostrarDatos(item);
                }
                    

            }

        }
        void mostrarDatos(Alumno al)
        {
            textBox1.Clear();
            textBox1.Text = textBox1.Text + " Preguntas totales: " + al.preguntasTotales + "\r\n Preguntas acertadas: "
                + al.preguntasAcertadas + "\r\n Preguntas falladas " + al.preguntasFalladas + " \r\n No contestadas: " 
                + (al.preguntasTotales - (al.preguntasAcertadas + al.preguntasFalladas));
        }

    }
}
