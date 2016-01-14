namespace Examen1_Apuestas
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewPremios = new System.Windows.Forms.DataGridView();
            this.dataGridViewPartidos = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPremios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewPremios
            // 
            this.dataGridViewPremios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPremios.Location = new System.Drawing.Point(12, 220);
            this.dataGridViewPremios.Name = "dataGridViewPremios";
            this.dataGridViewPremios.Size = new System.Drawing.Size(654, 173);
            this.dataGridViewPremios.TabIndex = 1;
            // 
            // dataGridViewPartidos
            // 
            this.dataGridViewPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartidos.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewPartidos.Name = "dataGridViewPartidos";
            this.dataGridViewPartidos.Size = new System.Drawing.Size(455, 173);
            this.dataGridViewPartidos.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Generar XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 419);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewPartidos);
            this.Controls.Add(this.dataGridViewPremios);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPremios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewPremios;
        private System.Windows.Forms.DataGridView dataGridViewPartidos;
        private System.Windows.Forms.Button button2;
    }
}

