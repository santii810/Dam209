using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADAT_UD1_Ejer2_Ahorcado
{
    public partial class Form1 : Form
    {
        static Fichero fich = new Fichero();
        static string rutaFichero = @"C:\Users\dam209\OneDrive\Proyectos\VisualStudio\ADAT_UD1_Ejer2_Ahorcado\palabras.txt";
        List<string> palabras = new List<string>(fich.LeerLinea(rutaFichero));
        List<char> letrasUsadas = new List<char>();
        string palabraMostrada;
        string palabraIncognita;
        int fallos = 0;

        public Form1()
        {
            InitializeComponent();
            Random r = new Random();
            int num = r.Next(palabras.Count);
            palabraIncognita = palabras[num].ToString().ToUpper();
            for (int i = 0; i < palabraIncognita.Length; i++)
            {
                palabraMostrada += "*";
            }
            txtPalabra.Text = palabraMostrada;
        }



        public void quitarAsteriscos()
        {
            palabraMostrada = "";
            for (int i = 0; i < palabraIncognita.Length; i++)
            {
                if (letrasUsadas.Contains(palabraIncognita[i]))
                {
                    palabraMostrada += palabraIncognita[i];
                }
                else
                {
                    palabraMostrada += "*";
                }
            }
            txtPalabra.Text = palabraMostrada;

        }

        public void partidaPerdida()
        {
            MessageBox.Show("Has perdido");
            lblNumFallos.BackColor = Color.Red;
            txtPalabra.Text = palabraIncognita;
            txtPalabra.ForeColor = Color.Red;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            
             if (!letrasUsadas.Contains(txtLetra.Text[0].ToString().ToUpper().ElementAt<char>(0)))
            {
                char letra = txtLetra.Text[0].ToString().ToUpper().ElementAt(0);
                letrasUsadas.Add(letra);
                if (!palabraIncognita.Contains(letra.ToString()))
                {
                    fallos++;
                }
                if (fallos > 4)
                    partidaPerdida();
                string tmp = "";
                foreach (char item in letrasUsadas)
                {
                    tmp+= " " + item.ToString();
                }
                lblLetras.Text = tmp;
                quitarAsteriscos();
                lblNumFallos.Text = fallos.ToString();
            }
        }

        private void txtLetra_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtLetra.Clear();
        }

        private void txtLetra_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txtLetra.Text = txtLetra.Text[0].ToString().ToUpper();
            }
            catch (Exception) { }
        }
    }
}
