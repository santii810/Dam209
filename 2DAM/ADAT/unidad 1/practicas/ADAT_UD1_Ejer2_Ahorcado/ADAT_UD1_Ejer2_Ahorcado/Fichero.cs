using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD1_Ejer2_Ahorcado
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
        public string leerFichero(string ruta)
        {
            if (abrirFichero(ruta))
            {
                StreamReader lector = new StreamReader(fich, Encoding.Default);
                String texto = lector.ReadToEnd();
                lector.Close();
                return texto;
            }
            else return null;


        }
        public List<string> LeerLinea(string ruta)
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

        public void agregar(string nombrefichero, string texto)
        {
            fich = new FileStream(nombrefichero, FileMode.Append, FileAccess.Write);
            if (File.Exists(nombrefichero))
            {
                if (!String.IsNullOrEmpty(texto))
                {
                    StreamWriter escritor = new StreamWriter(fich, Encoding.Default);
                    escritor.WriteLine(texto);
                    escritor.Close();
                }
            }

        }

    }
}

