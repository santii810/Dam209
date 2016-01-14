using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DINT_8._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void InitializeTimer()
        {


        }



        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (btnActivar.Text == "Activar")
            {
                btnActivar.Text = "Desactivar";
                timer1.Start();
            }
            else
            {
                btnActivar.Text = "Activar";
                timer1.Stop();
            }
        }
        private void dias()
        {
          


        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            string[] separador = { ":" };
            System.DateTime Fecha = System.DateTime.Now;
            string diasemana = DateTime.Today.DayOfWeek.ToString();

            String[] hora = mtbHora.Text.Split(separador, StringSplitOptions.RemoveEmptyEntries);

            int h = Convert.ToInt32(hora[0]);

            int m = Convert.ToInt32(hora[1]);
            int a = Fecha.Hour;
            int b = Fecha.Minute;
            if (rbHoy.Checked)
            {
                if (a == h && b == m)
                {
                    MessageBox.Show("Alarma Sonando");

                }

            }
            if (rbDia.Checked)
            {
                if (a == h && b == m)
                {
                    if (diasemana == "Sunday" && cbDomingo.Checked)
                    {
                        MessageBox.Show("Alarma Sonando");
                    }
                    if (diasemana == "Monday" && cbLunes.Checked)
                    {
                        MessageBox.Show("Alarma Sonando");
                    }
                    if (diasemana == "Tuesday" && cbMartes.Checked)
                    {
                        MessageBox.Show("Alarma Sonando");
                    }
                    if (diasemana == "Wenesday" && cbMiercoles.Checked)
                    {
                        MessageBox.Show("Alarma Sonando");
                    }
                    if (diasemana == "Thursday" && cbJueves.Checked)
                    {
                        MessageBox.Show("Alarma Sonando");
                    }
                    if (diasemana == "Friday" && cbViernes.Checked)
                    {
                        MessageBox.Show("Alarma Sonando");
                    }
                    if (diasemana == "Saturday" && cbSabado.Checked)
                    {
                        MessageBox.Show("Alarma Sonando");
                    }

                }
            }
        }
    }
}

