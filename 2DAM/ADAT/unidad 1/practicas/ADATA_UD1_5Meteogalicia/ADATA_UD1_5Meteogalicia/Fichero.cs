using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADATA_UD1_5Meteogalicia
{
    class Fichero
    {
        FileStream fich;

        public bool abrirFichero(String ruta)
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
        public List<string> LeerLineas(string ruta)
        {
            if (abrirFichero(ruta))
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

