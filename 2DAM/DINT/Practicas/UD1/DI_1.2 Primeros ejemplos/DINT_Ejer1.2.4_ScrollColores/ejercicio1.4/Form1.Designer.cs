namespace ejercicio1._4
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
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnFondo = new System.Windows.Forms.RadioButton();
            this.rbtnTexto = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.lblAzul = new System.Windows.Forms.Label();
            this.nudRojo = new System.Windows.Forms.NumericUpDown();
            this.nudVerde = new System.Windows.Forms.NumericUpDown();
            this.nudAzul = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAzul)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.MediumPurple;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Aqua;
            this.txtTitulo.Location = new System.Drawing.Point(100, 54);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(410, 44);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Módulo Diseño de Interfaces";
            this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFondo);
            this.groupBox1.Controls.Add(this.rbtnTexto);
            this.groupBox1.Location = new System.Drawing.Point(100, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rbtnFondo
            // 
            this.rbtnFondo.AutoSize = true;
            this.rbtnFondo.Checked = true;
            this.rbtnFondo.Location = new System.Drawing.Point(106, 20);
            this.rbtnFondo.Name = "rbtnFondo";
            this.rbtnFondo.Size = new System.Drawing.Size(55, 17);
            this.rbtnFondo.TabIndex = 1;
            this.rbtnFondo.TabStop = true;
            this.rbtnFondo.Text = "Fondo";
            this.rbtnFondo.UseVisualStyleBackColor = true;
            // 
            // rbtnTexto
            // 
            this.rbtnTexto.AutoSize = true;
            this.rbtnTexto.Location = new System.Drawing.Point(19, 20);
            this.rbtnTexto.Name = "rbtnTexto";
            this.rbtnTexto.Size = new System.Drawing.Size(52, 17);
            this.rbtnTexto.TabIndex = 0;
            this.rbtnTexto.Text = "Texto";
            this.rbtnTexto.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(435, 164);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.Location = new System.Drawing.Point(138, 235);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(29, 13);
            this.lblRojo.TabIndex = 3;
            this.lblRojo.Text = "Rojo";
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.Location = new System.Drawing.Point(138, 277);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(35, 13);
            this.lblVerde.TabIndex = 4;
            this.lblVerde.Text = "Verde";
            this.lblVerde.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.Location = new System.Drawing.Point(141, 323);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(27, 13);
            this.lblAzul.TabIndex = 5;
            this.lblAzul.Text = "Azul";
            // 
            // nudRojo
            // 
            this.nudRojo.Location = new System.Drawing.Point(206, 233);
            this.nudRojo.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudRojo.Name = "nudRojo";
            this.nudRojo.Size = new System.Drawing.Size(120, 20);
            this.nudRojo.TabIndex = 6;
            this.nudRojo.Value = new decimal(new int[] {
            155,
            0,
            0,
            0});
            this.nudRojo.ValueChanged += new System.EventHandler(this.nudRojo_ValueChanged);
            this.nudRojo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.nudRojo_ValueChanged);
            // 
            // nudVerde
            // 
            this.nudVerde.Location = new System.Drawing.Point(206, 275);
            this.nudVerde.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudVerde.Name = "nudVerde";
            this.nudVerde.Size = new System.Drawing.Size(120, 20);
            this.nudVerde.TabIndex = 7;
            this.nudVerde.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudVerde.ValueChanged += new System.EventHandler(this.nudVerde_ValueChanged);
            // 
            // nudAzul
            // 
            this.nudAzul.Location = new System.Drawing.Point(206, 321);
            this.nudAzul.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudAzul.Name = "nudAzul";
            this.nudAzul.Size = new System.Drawing.Size(120, 20);
            this.nudAzul.TabIndex = 8;
            this.nudAzul.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudAzul.ValueChanged += new System.EventHandler(this.nudAzul_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 400);
            this.Controls.Add(this.nudAzul);
            this.Controls.Add(this.nudVerde);
            this.Controls.Add(this.nudRojo);
            this.Controls.Add(this.lblAzul);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.lblRojo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTitulo);
            this.Name = "Form1";
            this.Text = "Seleccion de colores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAzul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFondo;
        private System.Windows.Forms.RadioButton rbtnTexto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.Label lblAzul;
        private System.Windows.Forms.NumericUpDown nudRojo;
        private System.Windows.Forms.NumericUpDown nudVerde;
        private System.Windows.Forms.NumericUpDown nudAzul;
    }
}

