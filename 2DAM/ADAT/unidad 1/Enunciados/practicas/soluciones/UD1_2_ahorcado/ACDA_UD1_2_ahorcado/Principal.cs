using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACDA_UD1_3_ahorcado
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
             FormConfiguracion formConfig = new FormConfiguracion();
             formConfig.TopLevel = false;
             formConfig.FormBorderStyle = FormBorderStyle.None;
             formConfig.Dock = DockStyle.Fill;
             this.panel1.Controls.Add(formConfig);
             this.panel1.Tag = formConfig;
             formConfig.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            FormJugar formJugar = new FormJugar();
            formJugar.TopLevel = false;
            formJugar.FormBorderStyle = FormBorderStyle.None;
            formJugar.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(formJugar);
            this.panel1.Tag = formJugar;
            formJugar.Show();
        }
    }
}
