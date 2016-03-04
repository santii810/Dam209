﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace _10_ClientePPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpClient client;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient(this.textBox1.Text, 2000);
                ns = client.GetStream();
                sr = new StreamReader(ns);
                sw = new StreamWriter(ns);
                //Console.WriteLine(sr.ReadLine());
                //Console.WriteLine(sr.ReadLine());
                //Console.WriteLine(sr.ReadLine());
                dato = sr.ReadLine() + System.Environment.NewLine+
                      sr.ReadLine() + System.Environment.NewLine+
                      sr.ReadLine();
                DelegadoRespuesta dr = new DelegadoRespuesta(EscribirFormulario);
                this.Invoke(dr); 


            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.ToString());
            }
        }

        String dato;
        delegate void DelegadoRespuesta();
        private void EscribirFormulario()
        {
            this.label1.Text = dato;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sw.WriteLine("#INSCRIBIR#" + this.textBox2.Text +"#");
            sw.Flush();
            dato = sr.ReadLine();

            DelegadoRespuesta dr = new DelegadoRespuesta(EscribirFormulario);
            this.Invoke(dr);         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sw.WriteLine("#JUGADA#" + this.comboBox1.Text+ "#");
            sw.Flush();
            dato = sr.ReadLine();

            DelegadoRespuesta dr = new DelegadoRespuesta(EscribirFormulario);
            this.Invoke(dr);              
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sw.WriteLine("#PUNTUACION#");
            sw.Flush();
            dato = sr.ReadLine();

            DelegadoRespuesta dr = new DelegadoRespuesta(EscribirFormulario);
            this.Invoke(dr); 
        }

    }
}
