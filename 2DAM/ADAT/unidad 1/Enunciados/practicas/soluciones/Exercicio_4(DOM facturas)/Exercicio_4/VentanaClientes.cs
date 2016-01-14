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
    public partial class VentanaClientes : Form
    {
        private Form1 mainWindow;
        public VentanaClientes(Form1 mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        FicheroXml doc;
        List<Cliente> list;

        private void VentanaClientes_Load(object sender, EventArgs e)
        {
            try

            { 
                doc = new FicheroXml(Application.StartupPath + "\\data\\clientes.xml");
                list = doc.LeerClientes();
                foreach (Cliente p in list)
                {
                    lbClientes.Items.Add(p.Codigo + " - " + p.Nombre);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ha habido un problema cargando el fichero de Productos");
            }
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            
        }

        private void lbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
              mainWindow.cliente = list[lbClientes.SelectedIndex];
        
              mainWindow.cargaclientes();
            this.Close();
        }
    }
}
