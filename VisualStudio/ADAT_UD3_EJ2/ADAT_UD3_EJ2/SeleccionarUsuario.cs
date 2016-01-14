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

    public partial class SeleccionarUsuario : Form
    {

        private Label labelUsuario;
        private TextBox textBoxUsuario;
        private GestorBD gestor;

        public SeleccionarUsuario(Label labelUsuario, TextBox textBoxUsuario)
        {
            InitializeComponent();
            this.labelUsuario = labelUsuario;
            this.textBoxUsuario = textBoxUsuario;
            gestor = new GestorBD();
            gestor.obtenerUsuarios();
            this.dataGridView1.DataSource = gestor.ds.Usuarios;
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBoxUsuario.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.labelUsuario.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }
    }
}
