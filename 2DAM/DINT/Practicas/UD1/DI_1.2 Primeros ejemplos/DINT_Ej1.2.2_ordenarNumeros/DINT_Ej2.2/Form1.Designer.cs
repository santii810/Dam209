namespace DINT_Ej2._2
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
            this.gbNumero = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.gbLista = new System.Windows.Forms.GroupBox();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.gbOrden = new System.Windows.Forms.GroupBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.rbtnDescendente = new System.Windows.Forms.RadioButton();
            this.rbtnAscendente = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnListaNueva = new System.Windows.Forms.Button();
            this.gbNumero.SuspendLayout();
            this.gbLista.SuspendLayout();
            this.gbOrden.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNumero
            // 
            this.gbNumero.Controls.Add(this.btnAgregar);
            this.gbNumero.Controls.Add(this.txtNumero);
            this.gbNumero.Location = new System.Drawing.Point(24, 47);
            this.gbNumero.Name = "gbNumero";
            this.gbNumero.Size = new System.Drawing.Size(200, 96);
            this.gbNumero.TabIndex = 0;
            this.gbNumero.TabStop = false;
            this.gbNumero.Text = "Introduce un numero";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(119, 36);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(6, 36);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // gbLista
            // 
            this.gbLista.Controls.Add(this.txtLista);
            this.gbLista.Location = new System.Drawing.Point(253, 47);
            this.gbLista.Name = "gbLista";
            this.gbLista.Size = new System.Drawing.Size(155, 212);
            this.gbLista.TabIndex = 1;
            this.gbLista.TabStop = false;
            this.gbLista.Text = "Lista";
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(6, 19);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(143, 187);
            this.txtLista.TabIndex = 1;
            // 
            // gbOrden
            // 
            this.gbOrden.Controls.Add(this.btnOrdenar);
            this.gbOrden.Controls.Add(this.rbtnDescendente);
            this.gbOrden.Controls.Add(this.rbtnAscendente);
            this.gbOrden.Location = new System.Drawing.Point(24, 149);
            this.gbOrden.Name = "gbOrden";
            this.gbOrden.Size = new System.Drawing.Size(200, 110);
            this.gbOrden.TabIndex = 2;
            this.gbOrden.TabStop = false;
            this.gbOrden.Text = "Orden";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(119, 33);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // rbtnDescendente
            // 
            this.rbtnDescendente.AutoSize = true;
            this.rbtnDescendente.Location = new System.Drawing.Point(21, 71);
            this.rbtnDescendente.Name = "rbtnDescendente";
            this.rbtnDescendente.Size = new System.Drawing.Size(89, 17);
            this.rbtnDescendente.TabIndex = 1;
            this.rbtnDescendente.TabStop = true;
            this.rbtnDescendente.Text = "Descendente";
            this.rbtnDescendente.UseVisualStyleBackColor = true;
            // 
            // rbtnAscendente
            // 
            this.rbtnAscendente.AutoSize = true;
            this.rbtnAscendente.Location = new System.Drawing.Point(21, 33);
            this.rbtnAscendente.Name = "rbtnAscendente";
            this.rbtnAscendente.Size = new System.Drawing.Size(82, 17);
            this.rbtnAscendente.TabIndex = 0;
            this.rbtnAscendente.TabStop = true;
            this.rbtnAscendente.Text = "Ascendente";
            this.rbtnAscendente.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(112, 294);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnListaNueva
            // 
            this.btnListaNueva.Location = new System.Drawing.Point(284, 294);
            this.btnListaNueva.Name = "btnListaNueva";
            this.btnListaNueva.Size = new System.Drawing.Size(75, 23);
            this.btnListaNueva.TabIndex = 4;
            this.btnListaNueva.Text = "Lista Nueva";
            this.btnListaNueva.UseVisualStyleBackColor = true;
            this.btnListaNueva.Click += new System.EventHandler(this.btnListaNueva_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 329);
            this.Controls.Add(this.btnListaNueva);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbOrden);
            this.Controls.Add(this.gbLista);
            this.Controls.Add(this.gbNumero);
            this.Name = "Form1";
            this.Text = "Ordena los numeros";
            this.gbNumero.ResumeLayout(false);
            this.gbNumero.PerformLayout();
            this.gbLista.ResumeLayout(false);
            this.gbLista.PerformLayout();
            this.gbOrden.ResumeLayout(false);
            this.gbOrden.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNumero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox gbLista;
        private System.Windows.Forms.GroupBox gbOrden;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.RadioButton rbtnDescendente;
        private System.Windows.Forms.RadioButton rbtnAscendente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnListaNueva;
        private System.Windows.Forms.TextBox txtLista;
    }
}

