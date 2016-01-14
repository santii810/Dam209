namespace PRSP_1Ejemplo
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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCerrarChrome = new System.Windows.Forms.Button();
            this.listBoxProcesos = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Notepad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Word";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCerrarChrome
            // 
            this.buttonCerrarChrome.Location = new System.Drawing.Point(13, 71);
            this.buttonCerrarChrome.Name = "buttonCerrarChrome";
            this.buttonCerrarChrome.Size = new System.Drawing.Size(75, 36);
            this.buttonCerrarChrome.TabIndex = 2;
            this.buttonCerrarChrome.Text = "Cerrar Chrome";
            this.buttonCerrarChrome.UseVisualStyleBackColor = true;
            this.buttonCerrarChrome.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxProcesos
            // 
            this.listBoxProcesos.FormattingEnabled = true;
            this.listBoxProcesos.Location = new System.Drawing.Point(201, 45);
            this.listBoxProcesos.Name = "listBoxProcesos";
            this.listBoxProcesos.Size = new System.Drawing.Size(119, 251);
            this.listBoxProcesos.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(201, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cerrar de lista";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 299);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBoxProcesos);
            this.Controls.Add(this.buttonCerrarChrome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonCerrarChrome;
        private System.Windows.Forms.ListBox listBoxProcesos;
        private System.Windows.Forms.Button button3;
    }
}

