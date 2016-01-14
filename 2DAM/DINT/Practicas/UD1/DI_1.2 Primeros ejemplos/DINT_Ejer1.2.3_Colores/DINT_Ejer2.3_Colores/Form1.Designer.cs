namespace DINT_Ejer2._3_Colores
{
    partial class Colores
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
            this.rbtnAzul = new System.Windows.Forms.RadioButton();
            this.rbtnRojo = new System.Windows.Forms.RadioButton();
            this.rbtnVerde = new System.Windows.Forms.RadioButton();
            this.rbtnAmarillo = new System.Windows.Forms.RadioButton();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbtnAzul
            // 
            this.rbtnAzul.AutoSize = true;
            this.rbtnAzul.Location = new System.Drawing.Point(12, 34);
            this.rbtnAzul.Name = "rbtnAzul";
            this.rbtnAzul.Size = new System.Drawing.Size(45, 17);
            this.rbtnAzul.TabIndex = 0;
            this.rbtnAzul.TabStop = true;
            this.rbtnAzul.Text = "Azul";
            this.rbtnAzul.UseVisualStyleBackColor = true;
            this.rbtnAzul.CheckedChanged += new System.EventHandler(this.rbtnAzul_CheckedChanged);
            // 
            // rbtnRojo
            // 
            this.rbtnRojo.AutoSize = true;
            this.rbtnRojo.Location = new System.Drawing.Point(12, 80);
            this.rbtnRojo.Name = "rbtnRojo";
            this.rbtnRojo.Size = new System.Drawing.Size(47, 17);
            this.rbtnRojo.TabIndex = 1;
            this.rbtnRojo.TabStop = true;
            this.rbtnRojo.Text = "Rojo";
            this.rbtnRojo.UseVisualStyleBackColor = true;
            this.rbtnRojo.CheckedChanged += new System.EventHandler(this.rbtnRojo_CheckedChanged);
            // 
            // rbtnVerde
            // 
            this.rbtnVerde.AutoSize = true;
            this.rbtnVerde.Location = new System.Drawing.Point(12, 57);
            this.rbtnVerde.Name = "rbtnVerde";
            this.rbtnVerde.Size = new System.Drawing.Size(53, 17);
            this.rbtnVerde.TabIndex = 2;
            this.rbtnVerde.TabStop = true;
            this.rbtnVerde.Text = "Verde";
            this.rbtnVerde.UseVisualStyleBackColor = true;
            this.rbtnVerde.CheckedChanged += new System.EventHandler(this.rbtnVerde_CheckedChanged);
            // 
            // rbtnAmarillo
            // 
            this.rbtnAmarillo.AutoSize = true;
            this.rbtnAmarillo.Location = new System.Drawing.Point(12, 103);
            this.rbtnAmarillo.Name = "rbtnAmarillo";
            this.rbtnAmarillo.Size = new System.Drawing.Size(61, 17);
            this.rbtnAmarillo.TabIndex = 3;
            this.rbtnAmarillo.TabStop = true;
            this.rbtnAmarillo.Text = "Amarillo";
            this.rbtnAmarillo.UseVisualStyleBackColor = true;
            this.rbtnAmarillo.CheckedChanged += new System.EventHandler(this.rbtnAmarillo_CheckedChanged);
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtColor.Location = new System.Drawing.Point(133, 34);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(139, 86);
            this.txtColor.TabIndex = 4;
            // 
            // Colores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 173);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.rbtnAmarillo);
            this.Controls.Add(this.rbtnVerde);
            this.Controls.Add(this.rbtnRojo);
            this.Controls.Add(this.rbtnAzul);
            this.Name = "Colores";
            this.Text = "Seleccion de colores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnAzul;
        private System.Windows.Forms.RadioButton rbtnRojo;
        private System.Windows.Forms.RadioButton rbtnVerde;
        private System.Windows.Forms.RadioButton rbtnAmarillo;
        private System.Windows.Forms.TextBox txtColor;
    }
}

