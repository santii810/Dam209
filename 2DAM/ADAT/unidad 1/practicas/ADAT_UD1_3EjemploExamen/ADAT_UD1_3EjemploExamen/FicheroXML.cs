using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ADAT_UD1_3EjemploExamen
{
    class FicheroXML
    {
        string nombreFicheroModulo;
        XmlDocument documento;
        XmlNode raiz;

        public Dictionary<int, Alumno> leerAlumnos()
        {
            Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();
            if (cargarXML())
            {
                foreach (XmlNode item in documento.GetElementsByTagName("Alumno"))
                {
                    int id = Convert.ToInt32(item.Attributes["id"].Value);
                    string nombre = item.InnerText;
                    alumnos.Add(id, new Alumno { Nombre = nombre ,IdAlumno = id});
                }
                return alumnos;
            }
            else return null;
        }

        public Dictionary<int, Alumno> leerFaltasModulo(int idModulo, int horasTotales, string nombreModulo)
        {
            if (cargarXML())
            {
                Dictionary<int, Alumno> alumnos = leerAlumnos();
                foreach (Alumno item in alumnos.Values.ToList<Alumno>())
                {
                    item.NombreModulo = nombreModulo;
                }
                foreach (XmlNode item in documento.GetElementsByTagName("Falta"))
                {
                    int idMod = Convert.ToInt32(item.Attributes["modulo"].Value);
                    if (idMod == idModulo)
                    {
                        alumnos[Convert.ToInt32(item.Attributes["IdAlumno"].Value)].HorasFaltadas++;
                        alumnos[Convert.ToInt32(item.Attributes["IdAlumno"].Value)].calcularPorcentajeFaltas(horasTotales);
                    }
                }
                return alumnos;
            }
            else return null;
        }
        
        public FicheroXML(string nombreFichero)
        {
            this.nombreFicheroModulo = nombreFichero;
        }

        public bool cargarXML()
        {
            if (File.Exists(nombreFicheroModulo))
            {
                documento = new XmlDocument();
                documento.Load(nombreFicheroModulo);
                raiz = documento.DocumentElement;
                return true;
            }
            else return false;
        }



        public void añadir(List<Alumno> alumnos)
        {
            string nombreFicheroModulo = alumnos[0].NombreModulo + ".xml";
            documento = new XmlDocument();
            if (!File.Exists(this.nombreFicheroModulo))
            {

                XmlDeclaration declaracion = documento.CreateXmlDeclaration("1.0", "UTF-8", null);
                documento.AppendChild(declaracion);
                raiz = documento.CreateElement("raiz");
                documento.AppendChild(raiz);
            }
            else
            {
                documento.Load(this.nombreFicheroModulo);
                raiz = documento.DocumentElement;
            }

            raiz.AppendChild(crearNodo(alumnos));

            documento.Save(this.nombreFicheroModulo);
        }
        public XmlNode crearNodo(List<Alumno> alumnos)
        {
            XmlElement InformeFaltas = documento.CreateElement("InformeFaltas");
            InformeFaltas.SetAttribute("Modulo", alumnos[0].NombreModulo);

            foreach (Alumno item in alumnos)
            {
                

                XmlElement nodoAlumno = documento.CreateElement("Alumno");
                nodoAlumno.SetAttribute("HorasFaltadas", item.HorasFaltadas.ToString());
                nodoAlumno.SetAttribute("PorcentajeFaltas", item.PorcentajeFaltas.ToString());

                XmlElement nombreAlumno = documento.CreateElement("Nombre");
                nombreAlumno.InnerText = item.Nombre;
                nombreAlumno.AppendChild(nodoAlumno);

                nodoAlumno.AppendChild(InformeFaltas);

            }
            return InformeFaltas;

        }
    }
}
