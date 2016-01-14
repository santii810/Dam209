using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;


namespace ModeloDom
{
    class XmlDom
    {
        string nombreFich;
        XmlDocument documento;
        XmlNode raiz;
        public XmlDom(string nombreFichero) {
            this.nombreFich = nombreFichero;
        }

        public XmlNode crearNodo(Libro libro)
        {

            //Creamos el nodo que deseamos insertar.
            XmlElement lib = documento.CreateElement("Libro");

            //Creamos los atributo NumejEmplares y codigo.   
            lib.SetAttribute("NumejEmplares", libro.NumEjemplares.ToString());
            lib.SetAttribute("codigo", libro.Codigo);

            /* otra forma de crear los atributos   
            //Creamos el atributo codigo. 
                  XmlAttribute idEmpleado = documento.CreateAttribute("Codigo");
                  idEmpleado.Value = libro.Codigo;
                  lib.Attributes.Append(idEmpleado);

                  //Creamos el atributo  numero ejemplares.
                  XmlAttribute NumEjemplares = documento.CreateAttribute("NumejEmplares");
                  NumEjemplares.Value = libro.NumEjemplares.ToString(); 
                  lib.Attributes.Append(NumEjemplares);

         */

            //Creamos el elemento apellidos.
            XmlElement isbn = documento.CreateElement("Isbn");
            isbn.InnerText = libro.Isbn;
            lib.AppendChild(isbn);
            //Creamos el elemento apellidos.
            XmlElement apellidos = documento.CreateElement("Apellidos");
            apellidos.InnerText = libro.ApellidosAutor;
            lib.AppendChild(apellidos);
            //Creamos el elemento nombre.
            XmlElement nombre = documento.CreateElement("Nombre");
            nombre.InnerText = libro.NombreAutor;
            lib.AppendChild(nombre);

            //Creamos el elemento TituloS.
            XmlElement titulo = documento.CreateElement("Titulo");
            titulo.InnerText = libro.Titulo;
            lib.AppendChild(titulo);

            return lib;

        }
        public void Añadir(Libro libro)
        {
            documento = new XmlDocument();
            if (!File.Exists(nombreFich))
            {

                XmlDeclaration declaracion = documento.CreateXmlDeclaration("1.0", "UTF-8", null);
                documento.AppendChild(declaracion);
                raiz = documento.CreateElement("Libros");
                documento.AppendChild(raiz);
            }
            else
            {
                documento.Load(nombreFich);
                raiz = documento.DocumentElement;
            }

            raiz.AppendChild(crearNodo(libro));

            documento.Save(nombreFich);

        }
        public void insertarPrincipio(Libro libro)
        {
            
            if (cargarXML())
            {
                
                // padre.InsertBefore(nodoAInsertar,padre.FirstChild): nodo padre  tras el que se quiere inserta ,  en este caso nodoPadre es la raiz En este caso nodoPadre es la raiz, se inserta antes de su primerhijo
                raiz.InsertBefore(crearNodo(libro), raiz.FirstChild);
                documento.Save(nombreFich);
            }
        }
        public void insertarAlFinal(Libro libro)
        {
            if (cargarXML())
            {
                // padre.InsertAfter(nodoAInsertar,padre.FirstChild): nodo padre  tras el que se quiere inserta. En este caso nodoPadre es la raiz, se inserta despues de su último hijo
               documento.DocumentElement.InsertAfter(crearNodo(libro), raiz.LastChild);
                documento.Save(nombreFich);
            }


        }
        public void insertarPorNodoRef(Libro libro, string codigoLibro)
        {XmlNode nodoref = BuscarNodo(codigoLibro);
        if (nodoref!=null)
            {   // padre.InsertAfter(nodoAInsertar,nodoRefencial): nodo padre  tras el que se quiere inserta. En este caso nodoPadre es la raiz,se inserta despues de un nodo que precisa una busqueda previa
                raiz.InsertAfter(crearNodo(libro), nodoref);
                documento.Save(nombreFich);
            }


        }

        public void borrarNodo(string codigoLibro)
        { XmlNode nodoref = BuscarNodoXpath(codigoLibro);
            if (nodoref!=null)
                {
                    raiz.RemoveChild(nodoref);
                    documento.Save(nombreFich);
                }
            }
        public void modificarNodo(string codigo,  Libro libroNuevo)
         {      
            XmlNode nodoLibroViejo =BuscarNodo(codigo);
            if (nodoLibroViejo != null)
                {
                    raiz.ReplaceChild(crearNodo(libroNuevo), nodoLibroViejo);
                    documento.Save(nombreFich);
                }
         }
        
        // busqueda pornexpresion XPATH
        public XmlNode BuscarNodoXpath(string codigo)
        {

            if (cargarXML())
            {
                documento = new XmlDocument();
                documento.Load(nombreFich);
                raiz = documento.DocumentElement;
                XmlNode nodo = documento.SelectSingleNode("Libros/Libro[@Codigo='" + codigo + "']");
                return nodo;

            }
            else return null;
        }
        // busqueda  por iteracion en una lista de nodos (XmlNodeList)
        public XmlNode BuscarNodo(string codigo)
        {
            if (cargarXML())
            {
                XmlNodeList listaNodos = documento.GetElementsByTagName("Libro");
                foreach (XmlNode nodo in listaNodos)
                {
                    if (nodo.Attributes["Codigo"].Value.Equals(codigo)) return nodo;
                }
                return null;

            }
            else return null;
        }
        public bool cargarXML()
        {

            if (File.Exists(nombreFich))
            {
                documento = new XmlDocument();
                documento.Load(nombreFich);
                raiz = documento.DocumentElement;
                return true;
            }
            else return false;
        }
        
    }
}


