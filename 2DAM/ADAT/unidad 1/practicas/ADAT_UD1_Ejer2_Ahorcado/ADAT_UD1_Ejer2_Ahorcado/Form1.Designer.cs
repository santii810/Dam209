namespace ADAT_UD1_Ejer2_Ahorcado
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
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUsado = new System.Windows.Forms.Label();
            this.lblLetras = new System.Windows.Forms.Label();
            this.lblTextFallos = new System.Windows.Forms.Label();
            this.lblNumFallos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPalabra
            // 
            this.txtPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalabra.Location = new System.Drawing.Point(13, 25);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(410, 62);
            this.txtPalabra.TabIndex = 0;
            // 
            // txtLetra
            // 
            this.txtLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra.Location = new System.Drawing.Point(13, 103);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(62, 62);
            this.txtLetra.TabIndex = 1;
            this.txtLetra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetra_KeyPress);
            this.txtLetra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLetra_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUsado
            // 
            this.lblUsado.AutoSize = true;
            this.lblUsado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsado.Location = new System.Drawing.Point(13, 221);
            this.lblUsado.Name = "lblUsado";
            this.lblUsado.Size = new System.Drawing.Size(193, 31);
            this.lblUsado.TabIndex = 3;
            this.lblUsado.Text = "Letras usadas:";
            // 
            // lblLetras
            // 
            this.lblLetras.AutoSize = true;
            this.lblLetras.Location = new System.Drawing.Point(10, 252);
            this.lblLetras.Name = "lblLetras";
            this.lblLetras.Size = new System.Drawing.Size(0, 13);
            this.lblLetras.TabIndex = 4;
            // 
            // lblTextFallos
            // 
            this.lblTextFallos.AutoSize = true;
            this.lblTextFallos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextFallos.Location = new System.Drawing.Point(317, 103);
            this.lblTextFallos.Name = "lblTextFallos";
            this.lblTextFallos.Size = new System.Drawing.Size(55, 20);
            this.lblTextFallos.TabIndex = 5;
            this.lblTextFallos.Text = "Fallos:";
            // 
            // lblNumFallos
            // 
            this.lblNumFallos.AutoSize = true;
            this.lblNumFallos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFallos.Location = new System.Drawing.Point(318, 123);
            this.lblNumFallos.Name = "lblNumFallos";
            this.lblNumFallos.Size = new System.Drawing.Size(39, 42);
            this.lblNumFallos.TabIndex = 6;
            this.lblNumFallos.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 301);
            this.Controls.Add(this.lblNumFallos);
            this.Controls.Add(this.lblTextFallos);
            this.Controls.Add(this.lblLetras);
            this.Controls.Add(this.lblUsado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.txtPalabra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUsado;
        private System.Windows.Forms.Label lblLetras;
        private System.Windows.Forms.Label lblTextFallos;
        private System.Windows.Forms.Label lblNumFallos;
    }
}

