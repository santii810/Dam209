using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ADAT_UD1_2XML_Ejer4_Factura
{
    class FicheroXML
    {
        string nombreFich;
        XmlDocument documento;
        XmlNode raiz;

        public FicheroXML(string nombreFichero)
        {
            this.nombreFich = nombreFichero;
        }

        public XmlNode crearNodo(Factura fact)
        {
            XmlElement factura = documento.CreateElement("Factura");
            XmlElement codigoFactura = documento.CreateElement("CodigoFactura");

            //Creamos el nodo CLIENTE.
            XmlElement nodoCliente = documento.CreateElement("Cliente");
            XmlElement codigo = documento.CreateElement("CodigoCliente");
            codigo.InnerText = fact.cliente.Nombre;
            nodoCliente.AppendChild(codigo);

            XmlElement nombre = documento.CreateElement("Nombre");
            nombre.InnerText = fact.cliente.Nombre;
            nodoCliente.AppendChild(nombre);

            XmlElement direccion = documento.CreateElement("Direccion");
            direccion.InnerText = fact.cliente.Direccion;
            nodoCliente.AppendChild(direccion);

            XmlElement fecha = documento.CreateElement("Fecha");
            fecha.InnerText = fact.cliente.Direccion;
            nodoCliente.AppendChild(fecha);


            XmlElement telefono = documento.CreateElement("Telefono");
            telefono.InnerText = fact.cliente.Telefono;
            nodoCliente.AppendChild(telefono);


            //creamos nodo Productos
            XmlElement nodoProductos = documento.CreateElement("Productos");
            foreach (Producto item in fact.productos)
            {
                XmlElement producto = documento.CreateElement("Producto");

                XmlElement codigoProducto = documento.CreateElement("CodigoProducto");
                codigoProducto.InnerText = item.codigo;
                producto.AppendChild(codigoProducto);

                XmlElement DescripcionProducto = documento.CreateElement("Descripcion");
                DescripcionProducto.InnerText = item.descripcion;
                producto.AppendChild(DescripcionProducto);

                XmlElement cantidad = documento.CreateElement("Cantidad");
                cantidad.InnerText = item.cantidad.ToString();
                producto.AppendChild(cantidad);

                XmlElement precio = documento.CreateElement("Precio");
                precio.InnerText = item.precio.ToString();
                producto.AppendChild(precio);

                XmlElement totalDeLinea = documento.CreateElement("TotalDeLinea");
                totalDeLinea.InnerText = item.totalDeLinea.ToString();
                producto.AppendChild(totalDeLinea);

                nodoProductos.AppendChild(producto);

            }
            factura.AppendChild(nodoCliente);
            factura.AppendChild(nodoProductos);

            return factura;

        }
        public void Añadir(Factura factura)
        {
            documento = new XmlDocument();
            if (!File.Exists(nombreFich))
            {

                XmlDeclaration declaracion = documento.CreateXmlDeclaration("1.0", "UTF-8", null);
                documento.AppendChild(declaracion);
                raiz = documento.CreateElement("Clientes");
                documento.AppendChild(raiz);
            }
            else
            {
                documento.Load(nombreFich);
                raiz = documento.DocumentElement;
            }

            raiz.AppendChild(crearNodo(factura));

            documento.Save(nombreFich);

        }
    }
}
