using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ADAT_UD1_2XML_Ej1_Partidos
{
    public partial class Form1 : Form
    {
        Fichero fich = new Fichero();
        Dictionary<int, string> equipos = new Dictionary<int, string>();
          List<Partido> partidos = new List<Partido>();
        string nombreFicheroEquipos = "equipos.txt";
        public Form1()
        {
            InitializeComponent();

            //cargar comboBox
            string directorio = Directory.GetCurrentDirectory();
            string[] fileNames = Directory.GetFiles(directorio, "jornada*.txt");
            foreach (string item in fileNames)
            {
                FileInfo fi = new FileInfo(item);
                string[] nom = fi.Name.Split('.');
                comboBox1.Items.Add(nom[0]);
            }

            //cargar equipos
            foreach (string item in fich.LeerLinea(nombreFicheroEquipos))
            {
                string[] linea = item.Split('-');
                int num = Convert.ToInt32(linea[0]);
                equipos.Add(num, linea[1]);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreFichero = comboBox1.SelectedItem.ToString() + ".txt";
            partidos.Clear();
            //cargar partidos
            foreach (string item in fich.LeerLinea(nombreFichero))
            {
                string[] linea = item.Split('-');
                partidos.Add(new Partido(Convert.ToInt32(linea[0]), linea[1], Convert.ToInt32(linea[2]), linea[3]));
            }

            //mostrar partidos
            dataGridView1.DataSource = partidos;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Partido>));
            TextWriter textWriter = new StreamWriter(Directory.GetCurrentDirectory() +  @"\partidos.xml");
            serializer.Serialize(textWriter, partidos);
            textWriter.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlSerializer desserializer = new XmlSerializer(typeof(List<Partido>));
            TextReader textReader = new StreamReader(Directory.GetCurrentDirectory() + @"\partidos.xml");
            List<Partido> lista = (List<Partido>)desserializer.Deserialize(textReader);
            textReader.Close();
            dataGridView1.DataSource = lista;
        }
    }
}
