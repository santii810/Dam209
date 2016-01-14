using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Collections;
using System.IO;
namespace aplicacionXml
{
    class FicheroXML
    {

        public ArrayList leerNodos(string nombreF)
        {      ArrayList lista=new ArrayList();
               Contacto c=new Contacto(); 
               FileStream fichero = new FileStream(nombreF, FileMode.Open, FileAccess.Read);
               XmlTextReader lectorXml = new XmlTextReader(fichero);
               while (lectorXml.Read())
               {

                  string v=lectorXml.Name;   // nombre del nodo
                  string x = lectorXml.Value; // valor
                   //while (lectorXml.MoveToNextAttribute()) -- recorremos los atributos de un nodo
                           
                   if (lectorXml.NodeType == XmlNodeType.Element)
                   {
                       switch (lectorXml.Name)
                       {
                           case "contacto": c = new Contacto(); ; break;
                           case "nombre":c.nombre= lectorXml.ReadString(); break;
                           case "apellido": c.apellido = lectorXml.ReadString(); ; break;
                           case "direccion": c.direccion = lectorXml.ReadString(); break;
                           case "telcasa": c.tfnoCasa = lectorXml.ReadString(); break;
                           case "telmovil": c.tfnoMovil = lectorXml.ReadString(); break;
                           case "teltrabajo": c.tfnoTrabajo = lectorXml.ReadString(); lista.Add(c); break;
                                                
                                              
                                            

                       }
                   }
               
               }
              lectorXml.Close();
              

           
            return lista;
          }

        public void escribirXMl(string nombreF, ArrayList contactos)
        {
            FileStream fichero = new FileStream(nombreF, FileMode.Create, FileAccess.Write);
            //crearXml(nombreF);
            XmlTextWriter escritorXml = new XmlTextWriter(fichero, Encoding.Default);
            escritorXml.Formatting = Formatting.Indented;
            escritorXml.WriteStartDocument();
            escritorXml.WriteStartElement("Agenda");
            foreach (Contacto c in contactos)
            {
                escritorXml.WriteStartElement("Contacto");
                    escritorXml.WriteStartElement("nombre", c.nombre);
                    escritorXml.WriteEndElement();
                    escritorXml.WriteStartElement("apellido",c.apellido);
                    escritorXml.WriteEndElement();
                    escritorXml.WriteStartElement("direccion", c.direccion);
                    escritorXml.WriteEndElement();
                    escritorXml.WriteStartElement("telefonos");
                        escritorXml.WriteStartElement("telcasa",  c.tfnoCasa);
                        escritorXml.WriteEndElement();
                        escritorXml.WriteStartElement("telmovil", c.tfnoMovil);
                        escritorXml.WriteEndElement();
                        escritorXml.WriteStartElement("teltrabajo",c.tfnoTrabajo );
                        escritorXml.WriteEndElement();
                    escritorXml.WriteEndElement();
               escritorXml.WriteEndElement();
            }
            
           escritorXml.WriteEndElement();
           escritorXml.WriteEndDocument();
           escritorXml.Close();
        }
        
        
        
        }
 }
 



    
