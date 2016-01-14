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

namespace ACDA_UD1_3_ahorcado
{
    public partial class FormJugar : Form
    {   ArchivoTexto fichero = new ArchivoTexto();
        ArrayList lista;
        string palSecreta;
        int cont=0;
        string nombreFich = "palabras.txt";
    
        public FormJugar()
        {
            InitializeComponent();
            lista = fichero.LeerLineas(nombreFich);
            iniciarPalabra();
            
        }

        
        private void buttonNuevaPalabra_Click(object sender, EventArgs e)
        {
            iniciarPalabra();
        }
    

        private void textBoxLetra_TextChanged(object sender, EventArgs e)
        {if (!string.IsNullOrEmpty(textBoxLetra.Text))   
            FormarPalabra(); 
         }    
            
        private void iniciarPalabra()
        {
            cont =0;
            palSecreta = PalabraAleatoria().ToUpper();

            palabra.Text = "";
            for (int i = 0; i < palSecreta.Length; i++)
            {
                palabra.Text += "*";
            }
            intentos.Text = (9 - cont).ToString();
            textBoxLetra.Enabled =true;
            textBoxAdivina.Enabled = true;
            textBoxAdivina.Text = "";
        }
        private string PalabraAleatoria()
        {
            Random azar = new Random();
            int pos = azar.Next(0, lista.Count);
            return lista[pos].ToString();
        }
        private void FormarPalabra()
        {
            bool letraOk = false;
            string palabraFormada = "";
            String  letra = textBoxLetra.Text;
            letra = letra.ToUpper();
            if (palSecreta.Contains(letra))
            {
                for (int i = 0; i < palSecreta.Length; i++)
                {
                    if (palSecreta[i].Equals(letra[0]))
                    { palabraFormada += letra;
                      letraOk = true;
                    
                    }
                    else { palabraFormada += palabra.Text[i]; }
                }
                palabra.Text = palabraFormada;
             
            }
            comprobarPalabra(letraOk);
        }
        private void comprobarPalabra(bool letraOk)
        {
            if (palabra.Text.Equals(palSecreta))
            {
                textBoxLetra.Enabled = false;
                MessageBox.Show("has ganado");
            }
            else
                {
                    if (!letraOk) { 
                        cont++;
                        intentos.Text = (9 - cont).ToString();
                        string rutaimg = @"imagenes/" + cont.ToString() + ".png";
                        pictureBox1.Image = Image.FromFile(rutaimg);
                     }
                    if (cont == 9)
                        {
                            textBoxLetra.Enabled = false;
                            MessageBox.Show("has agotado todos los intentos");
                        }
                }

        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if (textBoxAdivina.Text.Trim().ToUpper().Equals(palSecreta))
            {   palabra.Text=textBoxAdivina.Text;
                MessageBox.Show("Has acertado");
             }
            else MessageBox.Show("Has Fallado");
             
                textBoxLetra.Enabled = false;
                textBoxAdivina.Enabled = false;
             }

        private void botonAdd_Click(object sender, EventArgs e)
        {
            string pal = palabra.Text.ToUpper();
            fichero.agregar(nombreFich,pal);
        }

        
      }  
    }

