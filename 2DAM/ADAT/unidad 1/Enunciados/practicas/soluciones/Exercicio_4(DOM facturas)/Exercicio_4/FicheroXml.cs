using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Exercicio_4
{
    class FicheroXml
    {
        private string ruta;
        private XmlDocument doc;
        

        public FicheroXml(string ruta)
        {
            this.ruta = ruta;
         
            doc = new XmlDocument();
        
        }
       
          public Factura leerFactura()
        {
            doc = new XmlDocument();
            Factura factura = new Factura();
            doc.Load(ruta);
            XmlNodeList nodeList = doc.GetElementsByTagName("factura");

            foreach (XmlNode p in nodeList)
            {
                factura = new Factura();
                factura.Numero = Convert.ToInt32(p["cabecera"]["numero"].InnerText);
                factura.CodClient = p["cabecera"]["codClient"].InnerText;
                factura.NameClient = p["cabecera"]["nameClient"].InnerText;
                factura.DirClient = p["cabecera"]["dirClient"].InnerText;
                factura.TlfClient = Convert.ToInt32(p["cabecera"]["tlfClient"].InnerText);
                factura.Fecha = Convert.ToDateTime(p["cabecera"]["fecha"].InnerText);

                foreach(XmlNode n in p["detalles"].GetElementsByTagName("producto"))
                {
                    Producto prod = new Producto();
                    prod.Item = Convert.ToInt32(n["item"].InnerText);
                    prod.Codigo = n["codigo"].InnerText;
                    prod.Descripcion = n["descripcion"].InnerText;
                    prod.Cantidad = Convert.ToInt32(n["cantidad"].InnerText);
                    prod.Precio = Convert.ToDecimal(n["precio"].InnerText);
                    prod.Total = Convert.ToDecimal(n["precio"].InnerText);
                    factura.Products.Add(prod);
                }
                
            }return factura;
        }
        public void saveFacturaXML(Factura factura)
        {
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(xmlDeclaration);
            XmlElement raiz= doc.DocumentElement;
            doc.AppendChild(raiz);

            XmlNode fact = doc.CreateElement("factura");
            XmlNode cabecera = doc.CreateElement("cabecera");

            XmlNode numero = doc.CreateElement("numero");
            numero.InnerText = factura.Numero.ToString();
            cabecera.AppendChild(numero);

            XmlNode codClient = doc.CreateElement("codClient");
            codClient.InnerText = factura.CodClient.ToString();
            cabecera.AppendChild(codClient);

            XmlNode nameClient = doc.CreateElement("nameClient");
            nameClient.InnerText = factura.NameClient.ToString();
            cabecera.AppendChild(nameClient);

            XmlNode dirClient = doc.CreateElement("dirClient");
            dirClient.InnerText = factura.DirClient.ToString();
            cabecera.AppendChild(dirClient);

            XmlNode tlfClient = doc.CreateElement("tlfClient");
            tlfClient.InnerText = factura.TlfClient.ToString();
            cabecera.AppendChild(tlfClient);

            XmlNode fecha = doc.CreateElement("fecha");
            fecha.InnerText = factura.Fecha.ToString();
            cabecera.AppendChild(fecha);

            XmlNode detalles = doc.CreateElement("detalles");            

            foreach (Producto p in factura.Products)
            {
                detalles.InsertAfter(CrearNodosdetalle(p), detalles.LastChild);
            }

            fact.AppendChild(cabecera);
            fact.AppendChild(detalles);
            doc.AppendChild(fact);
            doc.Save(this.ruta);
        }
        public XmlNode CrearNodosdetalle(Producto prod)
        {
            XmlElement producto = doc.CreateElement("producto");

            XmlElement item = doc.CreateElement("item");
            item.InnerText = prod.Item.ToString();
            producto.AppendChild(item);

            XmlElement codigo = doc.CreateElement("codigo");
            codigo.InnerText = prod.Codigo.ToString();
            producto.AppendChild(codigo);

            XmlElement descripcion = doc.CreateElement("descripcion");
            descripcion.InnerText = prod.Codigo.ToString();
            producto.AppendChild(descripcion);

            XmlElement cantidad = doc.CreateElement("cantidad");
            cantidad.InnerText = prod.Cantidad.ToString();
            producto.AppendChild(cantidad);

            XmlElement precio = doc.CreateElement("precio");
            precio.InnerText = prod.Precio.ToString();
            producto.AppendChild(precio);

            XmlElement total = doc.CreateElement("total");
            total.InnerText = prod.Total.ToString();
            producto.AppendChild(total);

            return producto;
        }

        public List<Cliente> LeerClientes()
        {
            List<Cliente>  Client = new List<Cliente>();
            doc = new XmlDocument();
            doc.Load(ruta);
            XmlNodeList nodeList = doc.GetElementsByTagName("cliente");
            foreach (XmlNode p in nodeList)
            {
                Cliente item = new Cliente();
                item.Codigo = p["codigo"].InnerText;
                item.Nombre = p["nombre"].InnerText;
                item.Direccion = p["direccion"].InnerText;
                item.Telefono = Convert.ToInt32(p["telefono"].InnerText);
                Client.Add(item);
            }
            return Client;
        }
        public Cliente BuscarCliente(String codigo)
        {
            Cliente cli = new Cliente();
            doc = new XmlDocument();
            doc.Load(ruta);
            XmlNodeList nodeList = doc.GetElementsByTagName("cliente");
            foreach (XmlNode c in nodeList)
            {
                if (c["codigo"].InnerText.ToLower().Equals(codigo)) { 
                    cli= new Cliente();
                    cli.Codigo = c["codigo"].InnerText;
                    cli.Nombre = c["nombre"].InnerText;
                    cli.Direccion = c["direccion"].InnerText;
                    cli.Telefono = Convert.ToInt32(c["telefono"].InnerText);
               } 
            }
            return cli;
        }

        public List<Producto> leerProductos()
        {
            List<Producto> prod = new List<Producto>();
            doc = new XmlDocument();
            doc.Load(ruta);
            XmlNodeList nodeList = doc.GetElementsByTagName("producto");
            foreach (XmlNode p in nodeList)
            {
                Producto item = new Producto();
                item.Codigo = p["codigo"].InnerText;
                item.Descripcion = p["descripcion"].InnerText;
                item.Precio = Convert.ToDecimal(p["precio"].InnerText);
                prod.Add(item);                
            }
           return  prod;
        }
        public Producto buscarProducto(String codigo)
        {
            Producto item = new Producto();
            doc = new XmlDocument();
            doc.Load(ruta);
            XmlNodeList nodeList = doc.GetElementsByTagName("producto");
            foreach (XmlNode p in nodeList)
            {
                if (p["codigo"].InnerText.Equals(codigo)) { 
                 item = new Producto();
                item.Codigo = p["codigo"].InnerText;
                item.Descripcion = p["descripcion"].InnerText;
                item.Precio = Convert.ToDecimal(p["precio"].InnerText);
               }
            }
            return item;
        }
       
    }
}
