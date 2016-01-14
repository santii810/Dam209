using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADAT_UD3_EJ2
{
    public partial class FormHistorial : Form
    {
        GestorBD gestor;
        public FormHistorial()
        {
            InitializeComponent();
            gestor = new GestorBD();
            actualizarHistoriales();
        }

        private void historialesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historialesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.centroMedicoDataSet1);
            actualizarHistoriales();
            MessageBox.Show("Insertado");
            

        }

        private void Historial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'centroMedicoDataSet1.Historiales' Puede moverla o quitarla según sea necesario.
            this.historialesTableAdapter.Fill(this.centroMedicoDataSet1.Historiales);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new SeleccionarUsuario(labelNombreUsuario, usuarioTextBox)).Show();
        }


        private void actualizarHistoriales()
        {
            gestor.obtenerHistoriales();
            this.dataGridView1.DataSource = gestor.ds.Historiales;
        }
    }
}
