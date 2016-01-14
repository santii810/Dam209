using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Ecc;
using MessagingToolkit.QRCode.Codec.Data;
using MessagingToolkit.QRCode.Codec.Util;
using System.Drawing.Printing;

namespace Exercicio_4
{
    public partial class Form1 : Form
    {
        public Cliente cliente = new Cliente();
        public Producto producto = new Producto();
        public Form1()
        {
            InitializeComponent();
        }

        string ruta;
        public BindingList<Producto> BindingLista = new BindingList<Producto>();



        private void Form1_Load(object sender, EventArgs e)
        {
            dgv.DataSource = BindingLista;
            if (BindingLista.Count > 0)
            {
                calculatotal();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txbTelefono.Text != "" && txbTelefono.Text != "" && txbCodigo.Text != "" && txbNombre.Text != "" && txbDireccion.Text != "" && txbNumero.Text != "" && txbTelefono.Text != "")
            {
                if (Int32.Parse(txbTelefono.Text)>0 && Int32.Parse(txbNumero.Text)>0)
                {
                    ruta = Application.StartupPath + "\\data\\factura_" + txbNumero.Text + ".xml";
                    Factura fact = new Factura(Convert.ToInt32(txbNumero.Text), txbCodigo.Text, txbNombre.Text, txbDireccion.Text, Convert.ToInt32(txbTelefono.Text), BindingLista.ToList(), dtp.Value);
                    FicheroXml fich = new FicheroXml(ruta);
                    fich.saveFacturaXML(fact);
                }
                else
                {
                    MessageBox.Show("Por favor introduce valores númericos en Nº de factura y en el teléfono");
                }
            }
            else
            {
                MessageBox.Show("Algunos elementos del formulario están en blanco. por favor complétalos");
            }

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Application.StartupPath + "\\data\\";
            openFileDialog.Filter = "xml files (*.xml)|*.xml";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    try
                    {
                        ruta = openFileDialog.FileName;
                        FicheroXml doc = new FicheroXml(ruta);
                        Factura fac = doc.leerFactura();
                        txbCodigo.Text = fac.CodClient;
                        txbDireccion.Text = fac.DirClient;
                        txbNombre.Text = fac.NameClient;
                        txbTelefono.Text = fac.TlfClient.ToString();
                        txbNumero.Text = fac.Numero.ToString();
                        dtp.Value = fac.Fecha;
                        BindingLista = new BindingList<Producto>(fac.Products);


                        decimal total = 0;

                        foreach (Producto p in BindingLista)
                        {
                            total += p.Total;
                        }
                        txbTotal.Text = total.ToString();
                        dgv.DataSource = BindingLista;
                        calculatotal();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("El fichero seleccionado no tiene el formato correcto");
                    }
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txbCodigo.Text = "";
            txbDireccion.Text = "";
            txbNombre.Text = "";
            txbTelefono.Text = "";
            txbNumero.Text = "";
            dtp.Value = DateTime.Now;
            BindingLista = new BindingList<Producto>();
            dgv.DataSource = BindingLista;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            VentanaProductos productWindow = new VentanaProductos(this);

            productWindow.Show();
        }

        public void cargaclientes()
        {
            txbCodigo.Text = cliente.Codigo;
            txbDireccion.Text = cliente.Direccion;
            txbNombre.Text = cliente.Nombre;
            txbTelefono.Text = cliente.Telefono.ToString();
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            VentanaClientes productWindow = new VentanaClientes(this);
            productWindow.Show();
        }
       
        public void calculatotal()
        {
            decimal totalFact = 0;
            foreach (Producto p in BindingLista)
            {
                totalFact += p.Total;
            }
            txbTotal.Text = totalFact.ToString();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            if (BindingLista.Count > 0)
            {
                calculatotal();
            }
        }
        
     
        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {if (dgv.Rows[e.RowIndex].Cells[2].Value!=null){
            int total = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[3].Value) * Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[4].Value);
            BindingLista[e.RowIndex].Total = total;
            calculatotal();
            BindingLista.EndNew(e.RowIndex);
            dgv.Refresh();
           
        } 
        else  BindingLista.RemoveAt(e.RowIndex);
    }
        private void button1_Click(object sender, EventArgs e)
        {
            ruta = Application.StartupPath + "\\data\\Clientes.xml";
           
            FicheroXml fich = new FicheroXml(ruta);
            cliente=fich.BuscarCliente(this.txbCodigo.Text.Trim().ToLower());
            cargaclientes();
        }
    }
}