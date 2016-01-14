using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_4
{
    public partial class VentanaProductos : Form
    {
        private Form1 mainWindow;
        public VentanaProductos(Form1 mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        FicheroXml doc;
        List<Producto> list;     

        private void VentanaProductos_Load(object sender, EventArgs e)
        {
            try
            {
                doc = new FicheroXml(Application.StartupPath + "\\data\\productos.xml");
                list = doc.leerProductos();
                foreach (Producto p in list)
                {
                    lbProduct.Items.Add(p.Codigo + " - " + p.Descripcion);
                }
               
            }
            catch (Exception exc)
            {
                MessageBox.Show("Carga de  Productos erronea");
            }            
        }

       
        private void lbProduct_SelectedIndexChanged(object sender, EventArgs e)
        { 
            Producto p = list[lbProduct.SelectedIndex];
          //  mainWindow.BindingLista.endEdit();
            if (mainWindow.BindingLista.ToList().Find(c => c.Codigo == p.Codigo) == null)
            {

                
                p.Item = mainWindow.BindingLista.Count() + 1;
                p.Cantidad = 1;
                p.Total = p.Precio;
                //p.Cantidad = cantidad;
                //p.Total = total;
                mainWindow.BindingLista.Add(p);
                mainWindow.Refresh();
                mainWindow.calculatotal();
                this.Close();
            }
        }

       
       

 }
}

