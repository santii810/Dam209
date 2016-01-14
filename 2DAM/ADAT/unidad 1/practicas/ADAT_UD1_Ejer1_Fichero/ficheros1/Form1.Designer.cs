namespace ficheros1
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
            this.tbNombreArchivo = new System.Windows.Forms.TextBox();
            this.btnVerFrases = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.nuevoAutor = new System.Windows.Forms.TextBox();
            this.nuevaFrase = new System.Windows.Forms.TextBox();
            this.btnSiguientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFrases = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPagina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNombreArchivo
            // 
            this.tbNombreArchivo.Location = new System.Drawing.Point(40, 38);
            this.tbNombreArchivo.Name = "tbNombreArchivo";
            this.tbNombreArchivo.Size = new System.Drawing.Size(143, 20);
            this.tbNombreArchivo.TabIndex = 0;
            // 
            // btnVerFrases
            // 
            this.btnVerFrases.Location = new System.Drawing.Point(112, 64);
            this.btnVerFrases.Name = "btnVerFrases";
            this.btnVerFrases.Size = new System.Drawing.Size(71, 23);
            this.btnVerFrases.TabIndex = 2;
            this.btnVerFrases.Text = "Ver Frases";
            this.btnVerFrases.UseVisualStyleBackColor = true;
            this.btnVerFrases.Click += new System.EventHandler(this.btnVerFrases_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(40, 125);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(143, 20);
            this.tbBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(40, 151);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(40, 316);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(66, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // nuevoAutor
            // 
            this.nuevoAutor.Location = new System.Drawing.Point(40, 290);
            this.nuevoAutor.Name = "nuevoAutor";
            this.nuevoAutor.Size = new System.Drawing.Size(211, 20);
            this.nuevoAutor.TabIndex = 6;
            // 
            // nuevaFrase
            // 
            this.nuevaFrase.Location = new System.Drawing.Point(40, 240);
            this.nuevaFrase.Name = "nuevaFrase";
            this.nuevaFrase.Size = new System.Drawing.Size(211, 20);
            this.nuevaFrase.TabIndex = 7;
            // 
            // btnSiguientes
            // 
            this.btnSiguientes.Location = new System.Drawing.Point(497, 320);
            this.btnSiguientes.Name = "btnSiguientes";
            this.btnSiguientes.Size = new System.Drawing.Size(75, 23);
            this.btnSiguientes.TabIndex = 9;
            this.btnSiguientes.Text = ">>  Sig10";
            this.btnSiguientes.UseVisualStyleBackColor = true;
            this.btnSiguientes.Click += new System.EventHandler(this.btnSiguientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre del archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nueva Frase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Autor";
            // 
            // lbFrases
            // 
            this.lbFrases.FormattingEnabled = true;
            this.lbFrases.HorizontalScrollbar = true;
            this.lbFrases.Location = new System.Drawing.Point(278, 37);
            this.lbFrases.Name = "lbFrases";
            this.lbFrases.Size = new System.Drawing.Size(303, 277);
            this.lbFrases.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "FRASES CELEBRES";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(40, 64);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(66, 23);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = " Ant10   <<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Location = new System.Drawing.Point(389, 329);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(0, 13);
            this.lblPagina.TabIndex = 17;
            this.lblPagina.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 376);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbFrases);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSiguientes);
            this.Controls.Add(this.nuevaFrase);
            this.Controls.Add(this.nuevoAutor);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.btnVerFrases);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.tbNombreArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombreArchivo;
        private System.Windows.Forms.Button btnVerFrases;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox nuevoAutor;
        private System.Windows.Forms.TextBox nuevaFrase;
        private System.Windows.Forms.Button btnSiguientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbFrases;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPagina;
    }
}

