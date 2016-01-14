namespace ACDA_UD1_3_ahorcado
{
    partial class FormJugar
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLetra = new System.Windows.Forms.MaskedTextBox();
            this.palabra = new System.Windows.Forms.Label();
            this.intentos = new System.Windows.Forms.Label();
            this.buttonNuevaPalabra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdivina = new System.Windows.Forms.TextBox();
            this.buttonValidar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ACDA_UD1_3_ahorcado.Properties.Resources.ahorcado0;
            this.pictureBox1.Location = new System.Drawing.Point(216, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = " letra:";
            // 
            // textBoxLetra
            // 
            this.textBoxLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLetra.Location = new System.Drawing.Point(11, 189);
            this.textBoxLetra.Mask = "L";
            this.textBoxLetra.Name = "textBoxLetra";
            this.textBoxLetra.Size = new System.Drawing.Size(44, 53);
            this.textBoxLetra.TabIndex = 2;
            this.textBoxLetra.TextChanged += new System.EventHandler(this.textBoxLetra_TextChanged);
            // 
            // palabra
            // 
            this.palabra.AutoSize = true;
            this.palabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palabra.ForeColor = System.Drawing.Color.DarkRed;
            this.palabra.Location = new System.Drawing.Point(52, 50);
            this.palabra.Name = "palabra";
            this.palabra.Size = new System.Drawing.Size(173, 63);
            this.palabra.TabIndex = 3;
            this.palabra.Text = "label2";
            // 
            // intentos
            // 
            this.intentos.AutoSize = true;
            this.intentos.Location = new System.Drawing.Point(104, 284);
            this.intentos.Name = "intentos";
            this.intentos.Size = new System.Drawing.Size(13, 13);
            this.intentos.TabIndex = 5;
            this.intentos.Text = ": ";
            // 
            // buttonNuevaPalabra
            // 
            this.buttonNuevaPalabra.Location = new System.Drawing.Point(216, 0);
            this.buttonNuevaPalabra.Name = "buttonNuevaPalabra";
            this.buttonNuevaPalabra.Size = new System.Drawing.Size(118, 23);
            this.buttonNuevaPalabra.TabIndex = 6;
            this.buttonNuevaPalabra.Text = "NuevaPalabra";
            this.buttonNuevaPalabra.UseVisualStyleBackColor = true;
            this.buttonNuevaPalabra.Click += new System.EventHandler(this.buttonNuevaPalabra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Intentos restantes: ";
            // 
            // textBoxAdivina
            // 
            this.textBoxAdivina.Location = new System.Drawing.Point(6, 261);
            this.textBoxAdivina.Name = "textBoxAdivina";
            this.textBoxAdivina.Size = new System.Drawing.Size(154, 20);
            this.textBoxAdivina.TabIndex = 8;
            // 
            // buttonValidar
            // 
            this.buttonValidar.Location = new System.Drawing.Point(166, 261);
            this.buttonValidar.Name = "buttonValidar";
            this.buttonValidar.Size = new System.Drawing.Size(48, 23);
            this.buttonValidar.TabIndex = 9;
            this.buttonValidar.Text = "Validar";
            this.buttonValidar.UseVisualStyleBackColor = true;
            this.buttonValidar.Click += new System.EventHandler(this.buttonValidar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Palabra";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.palabra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonNuevaPalabra);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.intentos);
            this.groupBox1.Controls.Add(this.buttonValidar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxAdivina);
            this.groupBox1.Controls.Add(this.textBoxLetra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 307);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AHORCADO";
            // 
            // FormJugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 329);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormJugar";
            this.Text = "Jugar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textBoxLetra;
        private System.Windows.Forms.Label palabra;
        private System.Windows.Forms.Label intentos;
        private System.Windows.Forms.Button buttonNuevaPalabra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdivina;
        private System.Windows.Forms.Button buttonValidar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}