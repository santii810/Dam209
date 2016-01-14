using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ADATA_UD1_5Meteogalicia
{
    class FicheroMeteoXML
    {
        StreamReader fichero;
        XmlDocument documento;
        XmlNode raiz;
        public FicheroMeteoXML(StreamReader fichero)
        {
            this.fichero = fichero;
        }

        public bool cargarXML()
        {
            if (!fichero.Equals(StreamReader.Null))
            {
                documento = new XmlDocument();
                documento.Load(fichero);
                raiz = documento.DocumentElement;
                return true;
            }
            else return false;
        }

        public List<Meteo> leerDatos()
        {
            List<Meteo> retorno = new List<Meteo>();
            if (cargarXML())
            {
                foreach (XmlNode item in documento.GetElementsByTagName("Valores"))
                {
                    DateTime fecha = new DateTime( item.Attributes["Data"].Value)


                }




            }




            return retorno;
        }
       
    }
}
