using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Security.Cryptography;
using System.Collections;
namespace ACDA_UD1_3_ahorcado
{
    class ArchivoTexto
    {

        public FileStream fichero { get; set; }
        public string  clave="cifrado";
        public bool   abrirFichero(string nombre,int modo)
        {if (modo == 'L')
            {try
                {  fichero = new FileStream(nombre,FileMode.Open,FileAccess.Read);
                   return true;
                }
                catch (Exception ex)
                { return false; }
            }
            else
            {
                try
                {
                    { fichero = new FileStream(nombre, FileMode.Append,FileAccess.Write);
                      return true;
                    }
                    
                }

                catch (Exception e)
                { return false; }
                
            }
        }

        public string leerTodo(string nombre)
        {
            if (abrirFichero(nombre, 'L'))
            {
                StreamReader lector = new StreamReader(fichero, Encoding.Default);
                String texto = lector.ReadToEnd();
                lector.Close();
                return texto;
            }
            else return null;
        }
       
        public ArrayList LeerLineas(string nombre)
        {
            if (abrirFichero(nombre, 'L'))
            {
                ArrayList lineas = new ArrayList();
                StreamReader lector = new StreamReader(fichero, Encoding.Default,true);
                while (!lector.EndOfStream)
                    lineas.Add(descifrar(lector.ReadLine()));
                lector.Close();
                return lineas;
            }
            else return null;
       
        }

        public bool Existe(string nombreFich, string palabra)
        {  bool coincide = false;
            if (abrirFichero(nombreFich, 'L'))
            {
                StreamReader lector = new StreamReader(fichero);
                while (!lector.EndOfStream && coincide==false)
                {
                    string pal =descifrar (lector.ReadLine());
                    if ((pal).Equals(palabra))
                        coincide = true;
                }

                lector.Close();
            }
            return coincide;

        }

        public void agregar(string nombreFichero,string texto)
        {  if (!String.IsNullOrEmpty(texto) && !Existe(nombreFichero,texto))
             {if (abrirFichero(nombreFichero, 'E'))
                {   StreamWriter escritor = new StreamWriter(fichero, Encoding.Default);
                    escritor.WriteLine(cifrar(texto));
                    escritor.Close();
                }
            }
        }
        public string cifrar(string cadena) // Función para cifrar una cadena.
        {
            byte[] llave; //Array donde guardaremos la llave para el cifrado 3DES.
            byte[] arreglo = UTF8Encoding.UTF8.GetBytes(cadena); //Array donde guardaremos la cadena a cifrar.
            // Ciframos utilizando el Algoritmo MD5.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            llave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(clave));
            md5.Clear();
            //Ciframos utilizando el Algoritmo 3DES.
            TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
            tripledes.Key = llave;
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7;
            ICryptoTransform convertir = tripledes.CreateEncryptor();
            // Iniciamos la conversión de la cadena
            byte[] resultado = convertir.TransformFinalBlock(arreglo, 0, arreglo.Length);
            //Arreglo de bytes donde guardaremos la cadena cifrada.
            tripledes.Clear();
            return Convert.ToBase64String(resultado, 0, resultado.Length); // Convertimos la cadena y la regresamos.
        }

        public string descifrar(string cadena)
        {
            byte[] llave;
            byte[] arreglo = Convert.FromBase64String(cadena); // Arreay donde guardaremos la cadena descovertida.
            // Ciframos utilizando el Algoritmo MD5.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            llave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(clave));
            md5.Clear();
            //Ciframos utilizando el Algoritmo 3DES.
            TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
            tripledes.Key = llave;
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7;
            ICryptoTransform convertir = tripledes.CreateDecryptor();
            byte[] resultado = convertir.TransformFinalBlock(arreglo, 0, arreglo.Length);
            tripledes.Clear();
            string cadena_descifrada = UTF8Encoding.UTF8.GetString(resultado);
            // Obtenemos la cadena
            return cadena_descifrada; // Devolvemos la cadena
        }
        
    }
}
