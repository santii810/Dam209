namespace DINT_Examen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menItemNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.menItemGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menItemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.menProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.menAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPpal = new System.Windows.Forms.Label();
            this.lblSecundario = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripUsuarios = new System.Windows.Forms.ToolStripLabel();
            this.toolStripEspecialidades = new System.Windows.Forms.ToolStripLabel();
            this.toolStripinstrucciones = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMatricula = new System.Windows.Forms.ToolStripLabel();
            this.labelApellido1 = new System.Windows.Forms.Label();
            this.labelApellidoApellido2 = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxApellido1 = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.barra = new System.Windows.Forms.ToolStripStatusLabel();
            this.datosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menArchivo,
            this.menMantenimiento,
            this.menProcesos,
            this.menAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menArchivo
            // 
            this.menArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menItemNuevo,
            this.menItemGuardar,
            this.toolStripMenuItem1,
            this.menItemSalir});
            this.menArchivo.Name = "menArchivo";
            this.menArchivo.Size = new System.Drawing.Size(60, 20);
            this.menArchivo.Text = "Archivo";
            // 
            // menItemNuevo
            // 
            this.menItemNuevo.Image = ((System.Drawing.Image)(resources.GetObject("menItemNuevo.Image")));
            this.menItemNuevo.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.menItemNuevo.Name = "menItemNuevo";
            this.menItemNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menItemNuevo.Size = new System.Drawing.Size(158, 22);
            this.menItemNuevo.Text = "Nuevo";
            this.menItemNuevo.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // menItemGuardar
            // 
            this.menItemGuardar.Image = ((System.Drawing.Image)(resources.GetObject("menItemGuardar.Image")));
            this.menItemGuardar.Name = "menItemGuardar";
            this.menItemGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.menItemGuardar.Size = new System.Drawing.Size(158, 22);
            this.menItemGuardar.Text = "Guardar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
            // 
            // menItemSalir
            // 
            this.menItemSalir.Image = ((System.Drawing.Image)(resources.GetObject("menItemSalir.Image")));
            this.menItemSalir.Name = "menItemSalir";
            this.menItemSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menItemSalir.Size = new System.Drawing.Size(158, 22);
            this.menItemSalir.Text = "Salir";
            this.menItemSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // menMantenimiento
            // 
            this.menMantenimiento.Name = "menMantenimiento";
            this.menMantenimiento.Size = new System.Drawing.Size(101, 20);
            this.menMantenimiento.Text = "Mantenimiento";
            // 
            // menProcesos
            // 
            this.menProcesos.Name = "menProcesos";
            this.menProcesos.Size = new System.Drawing.Size(66, 20);
            this.menProcesos.Text = "Procesos";
            // 
            // menAyuda
            // 
            this.menAyuda.Name = "menAyuda";
            this.menAyuda.Size = new System.Drawing.Size(53, 20);
            this.menAyuda.Text = "Ayuda";
            // 
            // lblPpal
            // 
            this.lblPpal.AutoSize = true;
            this.lblPpal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPpal.Location = new System.Drawing.Point(131, 52);
            this.lblPpal.Name = "lblPpal";
            this.lblPpal.Size = new System.Drawing.Size(378, 25);
            this.lblPpal.TabIndex = 3;
            this.lblPpal.Text = "ADMINISTRACIÓN DE ESTUDIANTES";
            // 
            // lblSecundario
            // 
            this.lblSecundario.AutoSize = true;
            this.lblSecundario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecundario.Location = new System.Drawing.Point(215, 77);
            this.lblSecundario.Name = "lblSecundario";
            this.lblSecundario.Size = new System.Drawing.Size(133, 16);
            this.lblSecundario.TabIndex = 4;
            this.lblSecundario.Text = "Sistema de matrícula";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUsuarios,
            this.toolStripEspecialidades,
            this.toolStripinstrucciones,
            this.toolStripSeparator1,
            this.toolStripMatricula});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(632, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripUsuarios
            // 
            this.toolStripUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUsuarios.Image")));
            this.toolStripUsuarios.Name = "toolStripUsuarios";
            this.toolStripUsuarios.Size = new System.Drawing.Size(68, 22);
            this.toolStripUsuarios.Text = "Usuarios";
            // 
            // toolStripEspecialidades
            // 
            this.toolStripEspecialidades.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEspecialidades.Image")));
            this.toolStripEspecialidades.Name = "toolStripEspecialidades";
            this.toolStripEspecialidades.Size = new System.Drawing.Size(99, 22);
            this.toolStripEspecialidades.Text = "Especialidades";
            // 
            // toolStripinstrucciones
            // 
            this.toolStripinstrucciones.Image = ((System.Drawing.Image)(resources.GetObject("toolStripinstrucciones.Image")));
            this.toolStripinstrucciones.Name = "toolStripinstrucciones";
            this.toolStripinstrucciones.Size = new System.Drawing.Size(87, 22);
            this.toolStripinstrucciones.Text = "Instruciones";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripMatricula
            // 
            this.toolStripMatricula.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMatricula.Image")));
            this.toolStripMatricula.Name = "toolStripMatricula";
            this.toolStripMatricula.Size = new System.Drawing.Size(73, 22);
            this.toolStripMatricula.Text = "Matricula";
            // 
            // labelApellido1
            // 
            this.labelApellido1.AutoSize = true;
            this.labelApellido1.Location = new System.Drawing.Point(3, 14);
            this.labelApellido1.Name = "labelApellido1";
            this.labelApellido1.Size = new System.Drawing.Size(57, 13);
            this.labelApellido1.TabIndex = 6;
            this.labelApellido1.Text = "1º Apellido";
            // 
            // labelApellidoApellido2
            // 
            this.labelApellidoApellido2.AutoSize = true;
            this.labelApellidoApellido2.Location = new System.Drawing.Point(137, 14);
            this.labelApellidoApellido2.Name = "labelApellidoApellido2";
            this.labelApellidoApellido2.Size = new System.Drawing.Size(57, 13);
            this.labelApellidoApellido2.TabIndex = 7;
            this.labelApellidoApellido2.Text = "2º Apellido";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(137, 53);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelDireccion.TabIndex = 8;
            this.labelDireccion.Text = "Direccion";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(0, 53);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 9;
            this.labelDNI.Text = "DNI";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(275, 14);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 10;
            this.labelNombre.Text = "Nombre";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(84, 3);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 11;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(3, 32);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Enabled = false;
            this.buttonModificar.Location = new System.Drawing.Point(84, 32);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 13;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Enabled = false;
            this.buttonEliminar.Location = new System.Drawing.Point(3, 61);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 14;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Enabled = false;
            this.buttonNuevo.Location = new System.Drawing.Point(3, 3);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevo.TabIndex = 15;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(84, 61);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 16;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonNuevo);
            this.flowLayoutPanel1.Controls.Add(this.buttonGuardar);
            this.flowLayoutPanel1.Controls.Add(this.buttonCancelar);
            this.flowLayoutPanel1.Controls.Add(this.buttonModificar);
            this.flowLayoutPanel1.Controls.Add(this.buttonEliminar);
            this.flowLayoutPanel1.Controls.Add(this.buttonCerrar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(419, 106);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(163, 98);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // textBoxApellido1
            // 
            this.textBoxApellido1.Location = new System.Drawing.Point(6, 30);
            this.textBoxApellido1.Name = "textBoxApellido1";
            this.textBoxApellido1.Size = new System.Drawing.Size(95, 20);
            this.textBoxApellido1.TabIndex = 18;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(277, 30);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(95, 20);
            this.textBoxNombre.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(140, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(95, 20);
            this.textBox3.TabIndex = 20;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(3, 69);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(95, 20);
            this.textBoxDNI.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxDireccion);
            this.panel1.Controls.Add(this.labelApellido1);
            this.panel1.Controls.Add(this.textBoxDNI);
            this.panel1.Controls.Add(this.labelDNI);
            this.panel1.Controls.Add(this.labelApellidoApellido2);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.labelDireccion);
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Controls.Add(this.textBoxApellido1);
            this.panel1.Location = new System.Drawing.Point(12, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 98);
            this.panel1.TabIndex = 22;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(140, 71);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(232, 20);
            this.textBoxDireccion.TabIndex = 22;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.DataSource = this.datosBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 220);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(566, 188);
            this.dataGridView.TabIndex = 23;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barra});
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // barra
            // 
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(138, 17);
            this.barra.Text = "Fecha actual del sistema:";
            // 
            // datosBindingSource
            // 
            this.datosBindingSource.DataSource = typeof(DINT_Examen.Datos);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 471);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblSecundario);
            this.Controls.Add(this.lblPpal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(648, 510);
            this.MinimumSize = new System.Drawing.Size(648, 510);
            this.Name = "Form1";
            this.Text = "Bienvenidos al sistema de matricula";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menArchivo;
        private System.Windows.Forms.ToolStripMenuItem menItemNuevo;
        private System.Windows.Forms.ToolStripMenuItem menItemGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menItemSalir;
        private System.Windows.Forms.ToolStripMenuItem menMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem menProcesos;
        private System.Windows.Forms.ToolStripMenuItem menAyuda;
        private System.Windows.Forms.Label lblPpal;
        private System.Windows.Forms.Label lblSecundario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripUsuarios;
        private System.Windows.Forms.ToolStripLabel toolStripEspecialidades;
        private System.Windows.Forms.ToolStripLabel toolStripinstrucciones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripMatricula;
        private System.Windows.Forms.Label labelApellido1;
        private System.Windows.Forms.Label labelApellidoApellido2;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxApellido1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel barra;
        private System.Windows.Forms.BindingSource datosBindingSource;
    }
}

