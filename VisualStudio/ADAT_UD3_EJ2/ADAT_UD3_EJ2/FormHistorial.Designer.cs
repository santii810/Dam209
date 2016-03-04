namespace ADAT_UD3_EJ2
{
    partial class FormHistorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idHistoriaLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label medicoLabel;
            System.Windows.Forms.Label sintomasLabel;
            System.Windows.Forms.Label diagnosticoLabel;
            System.Windows.Forms.Label tratamientoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorial));
            this.centroMedicoDataSet1 = new ADAT_UD3_EJ2.CentroMedicoDataSet1();
            this.historialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialesTableAdapter = new ADAT_UD3_EJ2.CentroMedicoDataSet1TableAdapters.HistorialesTableAdapter();
            this.tableAdapterManager = new ADAT_UD3_EJ2.CentroMedicoDataSet1TableAdapters.TableAdapterManager();
            this.historialesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.historialesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idHistoriaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.medicoTextBox = new System.Windows.Forms.TextBox();
            this.sintomasTextBox = new System.Windows.Forms.TextBox();
            this.diagnosticoTextBox = new System.Windows.Forms.TextBox();
            this.tratamientoTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            idHistoriaLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            medicoLabel = new System.Windows.Forms.Label();
            sintomasLabel = new System.Windows.Forms.Label();
            diagnosticoLabel = new System.Windows.Forms.Label();
            tratamientoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.centroMedicoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialesBindingNavigator)).BeginInit();
            this.historialesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idHistoriaLabel
            // 
            idHistoriaLabel.AutoSize = true;
            idHistoriaLabel.Location = new System.Drawing.Point(12, 49);
            idHistoriaLabel.Name = "idHistoriaLabel";
            idHistoriaLabel.Size = new System.Drawing.Size(56, 13);
            idHistoriaLabel.TabIndex = 1;
            idHistoriaLabel.Text = "id Historia:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(12, 75);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(44, 13);
            usuarioLabel.TabIndex = 3;
            usuarioLabel.Text = "usuario:";
            // 
            // medicoLabel
            // 
            medicoLabel.AutoSize = true;
            medicoLabel.Location = new System.Drawing.Point(12, 101);
            medicoLabel.Name = "medicoLabel";
            medicoLabel.Size = new System.Drawing.Size(44, 13);
            medicoLabel.TabIndex = 5;
            medicoLabel.Text = "medico:";
            // 
            // sintomasLabel
            // 
            sintomasLabel.AutoSize = true;
            sintomasLabel.Location = new System.Drawing.Point(12, 127);
            sintomasLabel.Name = "sintomasLabel";
            sintomasLabel.Size = new System.Drawing.Size(51, 13);
            sintomasLabel.TabIndex = 7;
            sintomasLabel.Text = "sintomas:";
            // 
            // diagnosticoLabel
            // 
            diagnosticoLabel.AutoSize = true;
            diagnosticoLabel.Location = new System.Drawing.Point(12, 153);
            diagnosticoLabel.Name = "diagnosticoLabel";
            diagnosticoLabel.Size = new System.Drawing.Size(64, 13);
            diagnosticoLabel.TabIndex = 9;
            diagnosticoLabel.Text = "diagnostico:";
            // 
            // tratamientoLabel
            // 
            tratamientoLabel.AutoSize = true;
            tratamientoLabel.Location = new System.Drawing.Point(12, 179);
            tratamientoLabel.Name = "tratamientoLabel";
            tratamientoLabel.Size = new System.Drawing.Size(62, 13);
            tratamientoLabel.TabIndex = 11;
            tratamientoLabel.Text = "tratamiento:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(12, 206);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(37, 13);
            fechaLabel.TabIndex = 13;
            fechaLabel.Text = "fecha:";
            // 
            // centroMedicoDataSet1
            // 
            this.centroMedicoDataSet1.DataSetName = "CentroMedicoDataSet1";
            this.centroMedicoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historialesBindingSource
            // 
            this.historialesBindingSource.DataMember = "Historiales";
            this.historialesBindingSource.DataSource = this.centroMedicoDataSet1;
            // 
            // historialesTableAdapter
            // 
            this.historialesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CitasTableAdapter = null;
            this.tableAdapterManager.EspecialidadesTableAdapter = null;
            this.tableAdapterManager.HistorialesTableAdapter = this.historialesTableAdapter;
            this.tableAdapterManager.HorariosTableAdapter = null;
            this.tableAdapterManager.MedicosTableAdapter = null;
            this.tableAdapterManager.ServicioMedicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ADAT_UD3_EJ2.CentroMedicoDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // historialesBindingNavigator
            // 
            this.historialesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.historialesBindingNavigator.BindingSource = this.historialesBindingSource;
            this.historialesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.historialesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.historialesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.historialesBindingNavigatorSaveItem});
            this.historialesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.historialesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.historialesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.historialesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.historialesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.historialesBindingNavigator.Name = "historialesBindingNavigator";
            this.historialesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.historialesBindingNavigator.Size = new System.Drawing.Size(349, 25);
            this.historialesBindingNavigator.TabIndex = 0;
            this.historialesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // historialesBindingNavigatorSaveItem
            // 
            this.historialesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.historialesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("historialesBindingNavigatorSaveItem.Image")));
            this.historialesBindingNavigatorSaveItem.Name = "historialesBindingNavigatorSaveItem";
            this.historialesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.historialesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.historialesBindingNavigatorSaveItem.Click += new System.EventHandler(this.historialesBindingNavigatorSaveItem_Click);
            // 
            // idHistoriaTextBox
            // 
            this.idHistoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historialesBindingSource, "idHistoria", true));
            this.idHistoriaTextBox.Location = new System.Drawing.Point(82, 46);
            this.idHistoriaTextBox.Name = "idHistoriaTextBox";
            this.idHistoriaTextBox.Size = new System.Drawing.Size(200, 20);
            this.idHistoriaTextBox.TabIndex = 2;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historialesBindingSource, "usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(82, 72);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.ReadOnly = true;
            this.usuarioTextBox.Size = new System.Drawing.Size(56, 20);
            this.usuarioTextBox.TabIndex = 4;
            // 
            // medicoTextBox
            // 
            this.medicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historialesBindingSource, "medico", true));
            this.medicoTextBox.Location = new System.Drawing.Point(82, 98);
            this.medicoTextBox.Name = "medicoTextBox";
            this.medicoTextBox.Size = new System.Drawing.Size(200, 20);
            this.medicoTextBox.TabIndex = 6;
            // 
            // sintomasTextBox
            // 
            this.sintomasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historialesBindingSource, "sintomas", true));
            this.sintomasTextBox.Location = new System.Drawing.Point(82, 124);
            this.sintomasTextBox.Name = "sintomasTextBox";
            this.sintomasTextBox.Size = new System.Drawing.Size(200, 20);
            this.sintomasTextBox.TabIndex = 8;
            // 
            // diagnosticoTextBox
            // 
            this.diagnosticoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historialesBindingSource, "diagnostico", true));
            this.diagnosticoTextBox.Location = new System.Drawing.Point(82, 150);
            this.diagnosticoTextBox.Name = "diagnosticoTextBox";
            this.diagnosticoTextBox.Size = new System.Drawing.Size(200, 20);
            this.diagnosticoTextBox.TabIndex = 10;
            // 
            // tratamientoTextBox
            // 
            this.tratamientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historialesBindingSource, "tratamiento", true));
            this.tratamientoTextBox.Location = new System.Drawing.Point(82, 176);
            this.tratamientoTextBox.Name = "tratamientoTextBox";
            this.tratamientoTextBox.Size = new System.Drawing.Size(200, 20);
            this.tratamientoTextBox.TabIndex = 12;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.historialesBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(82, 202);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 14;
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Location = new System.Drawing.Point(144, 75);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(81, 13);
            this.labelNombreUsuario.TabIndex = 15;
            this.labelNombreUsuario.Text = "Nombre usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Seleccionar usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 187);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(idHistoriaLabel);
            this.Controls.Add(this.idHistoriaTextBox);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(medicoLabel);
            this.Controls.Add(this.medicoTextBox);
            this.Controls.Add(sintomasLabel);
            this.Controls.Add(this.sintomasTextBox);
            this.Controls.Add(diagnosticoLabel);
            this.Controls.Add(this.diagnosticoTextBox);
            this.Controls.Add(tratamientoLabel);
            this.Controls.Add(this.tratamientoTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.historialesBindingNavigator);
            this.Name = "FormHistorial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.centroMedicoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialesBindingNavigator)).EndInit();
            this.historialesBindingNavigator.ResumeLayout(false);
            this.historialesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CentroMedicoDataSet1 centroMedicoDataSet1;
        private System.Windows.Forms.BindingSource historialesBindingSource;
        private CentroMedicoDataSet1TableAdapters.HistorialesTableAdapter historialesTableAdapter;
        private CentroMedicoDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator historialesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton historialesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idHistoriaTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox medicoTextBox;
        private System.Windows.Forms.TextBox sintomasTextBox;
        private System.Windows.Forms.TextBox diagnosticoTextBox;
        private System.Windows.Forms.TextBox tratamientoTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}