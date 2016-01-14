namespace DINT_8._3
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHoy = new System.Windows.Forms.RadioButton();
            this.rbDia = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActivar = new System.Windows.Forms.Button();
            this.cbLunes = new System.Windows.Forms.CheckBox();
            this.cbMartes = new System.Windows.Forms.CheckBox();
            this.cbMiercoles = new System.Windows.Forms.CheckBox();
            this.cbJueves = new System.Windows.Forms.CheckBox();
            this.cbViernes = new System.Windows.Forms.CheckBox();
            this.cbSabado = new System.Windows.Forms.CheckBox();
            this.cbDomingo = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mtbHora = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHoy);
            this.groupBox1.Controls.Add(this.rbDia);
            this.groupBox1.Location = new System.Drawing.Point(108, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Alarma";
            // 
            // rbHoy
            // 
            this.rbHoy.AutoSize = true;
            this.rbHoy.Location = new System.Drawing.Point(132, 34);
            this.rbHoy.Name = "rbHoy";
            this.rbHoy.Size = new System.Drawing.Size(44, 17);
            this.rbHoy.TabIndex = 1;
            this.rbHoy.TabStop = true;
            this.rbHoy.Text = "Hoy";
            this.rbHoy.UseVisualStyleBackColor = true;
            // 
            // rbDia
            // 
            this.rbDia.AutoSize = true;
            this.rbDia.Location = new System.Drawing.Point(6, 34);
            this.rbDia.Name = "rbDia";
            this.rbDia.Size = new System.Drawing.Size(109, 17);
            this.rbDia.TabIndex = 0;
            this.rbDia.TabStop = true;
            this.rbDia.Text = "Día de la semana";
            this.rbDia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hora Alarma";
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(276, 161);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(120, 25);
            this.btnActivar.TabIndex = 3;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // cbLunes
            // 
            this.cbLunes.AutoSize = true;
            this.cbLunes.Location = new System.Drawing.Point(16, 245);
            this.cbLunes.Name = "cbLunes";
            this.cbLunes.Size = new System.Drawing.Size(55, 17);
            this.cbLunes.TabIndex = 4;
            this.cbLunes.Text = "Lunes";
            this.cbLunes.UseVisualStyleBackColor = true;
            // 
            // cbMartes
            // 
            this.cbMartes.AutoSize = true;
            this.cbMartes.Location = new System.Drawing.Point(102, 245);
            this.cbMartes.Name = "cbMartes";
            this.cbMartes.Size = new System.Drawing.Size(58, 17);
            this.cbMartes.TabIndex = 5;
            this.cbMartes.Text = "Martes";
            this.cbMartes.UseVisualStyleBackColor = true;
            // 
            // cbMiercoles
            // 
            this.cbMiercoles.AutoSize = true;
            this.cbMiercoles.Location = new System.Drawing.Point(188, 245);
            this.cbMiercoles.Name = "cbMiercoles";
            this.cbMiercoles.Size = new System.Drawing.Size(71, 17);
            this.cbMiercoles.TabIndex = 6;
            this.cbMiercoles.Text = "Miercoles";
            this.cbMiercoles.UseVisualStyleBackColor = true;
            // 
            // cbJueves
            // 
            this.cbJueves.AutoSize = true;
            this.cbJueves.Location = new System.Drawing.Point(276, 245);
            this.cbJueves.Name = "cbJueves";
            this.cbJueves.Size = new System.Drawing.Size(60, 17);
            this.cbJueves.TabIndex = 7;
            this.cbJueves.Text = "Jueves";
            this.cbJueves.UseVisualStyleBackColor = true;
            // 
            // cbViernes
            // 
            this.cbViernes.AutoSize = true;
            this.cbViernes.Location = new System.Drawing.Point(16, 290);
            this.cbViernes.Name = "cbViernes";
            this.cbViernes.Size = new System.Drawing.Size(61, 17);
            this.cbViernes.TabIndex = 8;
            this.cbViernes.Text = "Viernes";
            this.cbViernes.UseVisualStyleBackColor = true;
            // 
            // cbSabado
            // 
            this.cbSabado.AutoSize = true;
            this.cbSabado.Location = new System.Drawing.Point(102, 290);
            this.cbSabado.Name = "cbSabado";
            this.cbSabado.Size = new System.Drawing.Size(63, 17);
            this.cbSabado.TabIndex = 9;
            this.cbSabado.Text = "Sabado";
            this.cbSabado.UseVisualStyleBackColor = true;
            // 
            // cbDomingo
            // 
            this.cbDomingo.AutoSize = true;
            this.cbDomingo.Location = new System.Drawing.Point(188, 290);
            this.cbDomingo.Name = "cbDomingo";
            this.cbDomingo.Size = new System.Drawing.Size(68, 17);
            this.cbDomingo.TabIndex = 10;
            this.cbDomingo.Text = "Domingo";
            this.cbDomingo.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // mtbHora
            // 
            this.mtbHora.Location = new System.Drawing.Point(140, 166);
            this.mtbHora.Mask = "00:00";
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.Size = new System.Drawing.Size(100, 20);
            this.mtbHora.TabIndex = 11;
            this.mtbHora.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 405);
            this.Controls.Add(this.mtbHora);
            this.Controls.Add(this.cbDomingo);
            this.Controls.Add(this.cbSabado);
            this.Controls.Add(this.cbViernes);
            this.Controls.Add(this.cbJueves);
            this.Controls.Add(this.cbMiercoles);
            this.Controls.Add(this.cbMartes);
            this.Controls.Add(this.cbLunes);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbHoy;
        private System.Windows.Forms.RadioButton rbDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.CheckBox cbLunes;
        private System.Windows.Forms.CheckBox cbMartes;
        private System.Windows.Forms.CheckBox cbMiercoles;
        private System.Windows.Forms.CheckBox cbJueves;
        private System.Windows.Forms.CheckBox cbViernes;
        private System.Windows.Forms.CheckBox cbSabado;
        private System.Windows.Forms.CheckBox cbDomingo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox mtbHora;
    }
}

