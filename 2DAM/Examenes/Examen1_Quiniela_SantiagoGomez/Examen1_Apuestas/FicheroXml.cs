using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Examen1_Apuestas
{
    class FicheroXml
    {
        string nombreFichero;
        XmlDocument documento;
        XmlNode raiz;

        public FicheroXml(string nombreFichero)
        {
            this.nombreFichero = nombreFichero;
        }
        public bool cargarXML()
        {
            if (File.Exists(nombreFichero))
            {
                documento = new XmlDocument();
                documento.Load(nombreFichero);
                raiz = documento.DocumentElement;
                return true;
            }
            else return false;
        }
        public List<Partido> leerPartidos()
        {
            List<Partido> partidos = new List<Partido>();
            if (cargarXML())
            {
                foreach (XmlNode item in documento.GetElementsByTagName("Resultado"))
                {
                    partidos.Add(new Partido
                    {
                        id = Convert.ToInt32(item.Attributes["id"].Value),
                        equipoLocal = item.Attributes["equipoLocal"].Value,
                        equipoVisitante = item.Attributes["equipoVisit"].Value,
                        resultado = item.Attributes["rdo"].Value
                    });
                }
                return partidos;
            }
            return null;
        }

        public List<Pronostico> leerPronosticos(List<Partido> partidos)
        {
            if (cargarXML())
            {
                List<Pronostico> pronosticos = new List<Pronostico>();
                foreach (XmlNode itPronostico in documento.GetElementsByTagName("Pronostico"))
                {
                    Pronostico tmp = new Pronostico { id = Convert.ToInt32(itPronostico.Attributes["id"].Value) };
                    foreach (XmlNode itApuesta in itPronostico.ChildNodes)
                    {
                        tmp.addApuesta(
                            new Apuesta(itApuesta.Attributes["id"].Value,
                            itApuesta.Attributes["pronostico"].Value,
                            partidos));
                    }
                    pronosticos.Add(tmp);
                }
                return pronosticos;
            }


            return null;
        }
        public int leerRecaudacion()
        {
            if (cargarXML())
            {
                return Convert.ToInt32(documento.GetElementsByTagName("Recaudacion").Item(0).Attributes["valor"].Value);
            }
            return 0;
        }



        public void añadir(List<Premios> premios)
        {

            documento = new XmlDocument();
            if (File.Exists(this.nombreFichero))
            {

                documento.Load(this.nombreFichero);
                raiz = documento.DocumentElement;
                XmlNodeList tmp = documento.GetElementsByTagName("Resultados");
                if (tmp.Count < 1)
                {
                    raiz.InsertAfter(crearNodo(premios),documento.GetElementsByTagName("Recaudacion")[0]);
                    documento.Save(this.nombreFichero);
                }
            }
        }

        public XmlNode crearNodo(List<Premios> premios)
        {
            XmlElement nodoResultados = documento.CreateElement("Resultados");
            
            foreach (Premios item in premios)
            {
                XmlElement categoria = documento.CreateElement("Categoria");
                categoria.SetAttribute("id", item.Categoria.ToString());
                categoria.SetAttribute("acertantes", item.Acertantes.ToString());
                categoria.SetAttribute("premioUnitario", item.PremioUnitario.ToString());

                nodoResultados.AppendChild(categoria);

            }
            return nodoResultados;
        }

        
    }

    class Fichero
    {
        FileStream fich;
        string ruta;
        public Fichero(string ruta)
        {
            this.ruta = ruta;
        }
        public bool abrirFichero()
        {
            try
            {
                if (File.Exists(ruta))
                {
                    fich = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public List<string> LeerLineas()
        {
            if (abrirFichero())
            {
                List<string> lineas = new List<string>();
                StreamReader lector = new StreamReader(fich, Encoding.Default, true);
                while (!lector.EndOfStream)
                    lineas.Add(lector.ReadLine());
                lector.Close();
                return lineas;
            }
            else return null;
        }
    }
}
