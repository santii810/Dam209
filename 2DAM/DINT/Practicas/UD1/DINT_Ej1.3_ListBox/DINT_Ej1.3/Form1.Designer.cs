namespace DINT_Ej1._3
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
            this.btnMoverTodoADestino = new System.Windows.Forms.Button();
            this.btnMoverADestino = new System.Windows.Forms.Button();
            this.btnMoverTodoAFuente = new System.Windows.Forms.Button();
            this.btnMoverAFuente = new System.Windows.Forms.Button();
            this.btnAñadirF = new System.Windows.Forms.Button();
            this.btnAñadirD = new System.Windows.Forms.Button();
            this.btnEliminarF = new System.Windows.Forms.Button();
            this.btnEliminarD = new System.Windows.Forms.Button();
            this.btnEliminarTodoF = new System.Windows.Forms.Button();
            this.btnEliminarTodoD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstFuente = new System.Windows.Forms.ListBox();
            this.lstDestino = new System.Windows.Forms.ListBox();
            this.txtF = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMoverTodoADestino
            // 
            this.btnMoverTodoADestino.Location = new System.Drawing.Point(119, 40);
            this.btnMoverTodoADestino.Name = "btnMoverTodoADestino";
            this.btnMoverTodoADestino.Size = new System.Drawing.Size(42, 23);
            this.btnMoverTodoADestino.TabIndex = 2;
            this.btnMoverTodoADestino.Text = ">>";
            this.btnMoverTodoADestino.UseVisualStyleBackColor = true;
            this.btnMoverTodoADestino.Click += new System.EventHandler(this.btnMoverTodoADestino_Click);
            // 
            // btnMoverADestino
            // 
            this.btnMoverADestino.Location = new System.Drawing.Point(119, 69);
            this.btnMoverADestino.Name = "btnMoverADestino";
            this.btnMoverADestino.Size = new System.Drawing.Size(42, 23);
            this.btnMoverADestino.TabIndex = 5;
            this.btnMoverADestino.Text = ">";
            this.btnMoverADestino.UseVisualStyleBackColor = true;
            this.btnMoverADestino.Click += new System.EventHandler(this.btnMoverADestino_Click);
            // 
            // btnMoverTodoAFuente
            // 
            this.btnMoverTodoAFuente.Location = new System.Drawing.Point(119, 127);
            this.btnMoverTodoAFuente.Name = "btnMoverTodoAFuente";
            this.btnMoverTodoAFuente.Size = new System.Drawing.Size(42, 23);
            this.btnMoverTodoAFuente.TabIndex = 6;
            this.btnMoverTodoAFuente.Text = "<<";
            this.btnMoverTodoAFuente.UseVisualStyleBackColor = true;
            this.btnMoverTodoAFuente.Click += new System.EventHandler(this.btnMoverTodoAFuente_Click);
            // 
            // btnMoverAFuente
            // 
            this.btnMoverAFuente.Location = new System.Drawing.Point(119, 98);
            this.btnMoverAFuente.Name = "btnMoverAFuente";
            this.btnMoverAFuente.Size = new System.Drawing.Size(42, 23);
            this.btnMoverAFuente.TabIndex = 7;
            this.btnMoverAFuente.Text = "<";
            this.btnMoverAFuente.UseVisualStyleBackColor = true;
            this.btnMoverAFuente.Click += new System.EventHandler(this.btnMoverAFuente_Click);
            // 
            // btnAñadirF
            // 
            this.btnAñadirF.Location = new System.Drawing.Point(12, 203);
            this.btnAñadirF.Name = "btnAñadirF";
            this.btnAñadirF.Size = new System.Drawing.Size(114, 23);
            this.btnAñadirF.TabIndex = 8;
            this.btnAñadirF.Text = "Añadir Elemento";
            this.btnAñadirF.UseVisualStyleBackColor = true;
            this.btnAñadirF.Click += new System.EventHandler(this.btnAñadirF_Click);
            // 
            // btnAñadirD
            // 
            this.btnAñadirD.Location = new System.Drawing.Point(153, 203);
            this.btnAñadirD.Name = "btnAñadirD";
            this.btnAñadirD.Size = new System.Drawing.Size(114, 23);
            this.btnAñadirD.TabIndex = 9;
            this.btnAñadirD.Text = "Añadir Elemento";
            this.btnAñadirD.UseVisualStyleBackColor = true;
            this.btnAñadirD.Click += new System.EventHandler(this.btnAñadirD_Click);
            // 
            // btnEliminarF
            // 
            this.btnEliminarF.Location = new System.Drawing.Point(12, 232);
            this.btnEliminarF.Name = "btnEliminarF";
            this.btnEliminarF.Size = new System.Drawing.Size(114, 34);
            this.btnEliminarF.TabIndex = 10;
            this.btnEliminarF.Text = "Eliminar elementos seleccionados";
            this.btnEliminarF.UseVisualStyleBackColor = true;
            this.btnEliminarF.Click += new System.EventHandler(this.btnEliminarF_Click);
            // 
            // btnEliminarD
            // 
            this.btnEliminarD.Location = new System.Drawing.Point(153, 232);
            this.btnEliminarD.Name = "btnEliminarD";
            this.btnEliminarD.Size = new System.Drawing.Size(114, 34);
            this.btnEliminarD.TabIndex = 11;
            this.btnEliminarD.Text = "Eliminar elementos seleccionados";
            this.btnEliminarD.UseVisualStyleBackColor = true;
            this.btnEliminarD.Click += new System.EventHandler(this.btnEliminarD_Click);
            // 
            // btnEliminarTodoF
            // 
            this.btnEliminarTodoF.Location = new System.Drawing.Point(12, 272);
            this.btnEliminarTodoF.Name = "btnEliminarTodoF";
            this.btnEliminarTodoF.Size = new System.Drawing.Size(114, 34);
            this.btnEliminarTodoF.TabIndex = 12;
            this.btnEliminarTodoF.Text = "Eliminar todos los elementos";
            this.btnEliminarTodoF.UseVisualStyleBackColor = true;
            this.btnEliminarTodoF.Click += new System.EventHandler(this.btnEliminarTodoF_Click);
            // 
            // btnEliminarTodoD
            // 
            this.btnEliminarTodoD.Location = new System.Drawing.Point(153, 272);
            this.btnEliminarTodoD.Name = "btnEliminarTodoD";
            this.btnEliminarTodoD.Size = new System.Drawing.Size(114, 34);
            this.btnEliminarTodoD.TabIndex = 13;
            this.btnEliminarTodoD.Text = "Eliminar todos los elementos";
            this.btnEliminarTodoD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lista sin ordenar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lista ordenada";
            // 
            // lstFuente
            // 
            this.lstFuente.FormattingEnabled = true;
            this.lstFuente.Items.AddRange(new object[] {
            "Luis",
            "Carmen",
            "Tomás",
            "Marta",
            "Ramón"});
            this.lstFuente.Location = new System.Drawing.Point(13, 26);
            this.lstFuente.Name = "lstFuente";
            this.lstFuente.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstFuente.Size = new System.Drawing.Size(100, 134);
            this.lstFuente.TabIndex = 16;
            // 
            // lstDestino
            // 
            this.lstDestino.FormattingEnabled = true;
            this.lstDestino.Location = new System.Drawing.Point(167, 26);
            this.lstDestino.Name = "lstDestino";
            this.lstDestino.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDestino.Size = new System.Drawing.Size(100, 134);
            this.lstDestino.TabIndex = 17;
            this.lstDestino.SelectedIndexChanged += new System.EventHandler(this.lstDestino_SelectedIndexChanged);
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(12, 176);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(114, 20);
            this.txtF.TabIndex = 18;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(153, 177);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(114, 20);
            this.txtD.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.lstDestino);
            this.Controls.Add(this.lstFuente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarTodoD);
            this.Controls.Add(this.btnEliminarTodoF);
            this.Controls.Add(this.btnEliminarD);
            this.Controls.Add(this.btnEliminarF);
            this.Controls.Add(this.btnAñadirD);
            this.Controls.Add(this.btnAñadirF);
            this.Controls.Add(this.btnMoverAFuente);
            this.Controls.Add(this.btnMoverTodoAFuente);
            this.Controls.Add(this.btnMoverADestino);
            this.Controls.Add(this.btnMoverTodoADestino);
            this.Name = "Form1";
            this.Text = "Control ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMoverTodoADestino;
        private System.Windows.Forms.Button btnMoverADestino;
        private System.Windows.Forms.Button btnMoverTodoAFuente;
        private System.Windows.Forms.Button btnMoverAFuente;
        private System.Windows.Forms.Button btnAñadirF;
        private System.Windows.Forms.Button btnAñadirD;
        private System.Windows.Forms.Button btnEliminarF;
        private System.Windows.Forms.Button btnEliminarD;
        private System.Windows.Forms.Button btnEliminarTodoF;
        private System.Windows.Forms.Button btnEliminarTodoD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstFuente;
        private System.Windows.Forms.ListBox lstDestino;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.TextBox txtD;
    }
}

