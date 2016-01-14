using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1_santiagoGomez
{
    public partial class Form1 : Form
    {
        int acum = 0;
        bool bloqueado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcpListener newsock = new TcpListener(IPAddress.Any, 2000);
            newsock.Start();
            while (true)
            {
                TcpClient cliente = newsock.AcceptTcpClient();
                Thread t = new Thread(() => this.ManejarCliente(cliente));
                t.Start();
            }
        }



        private void ManejarCliente(TcpClient cli)
        {
            int lectura;
            NetworkStream ns = cli.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            sw.WriteLine("Bienvenido, intenta adivinar mi numero");
            sw.Flush();
            while (true)
            {
                try
                {
                    sw.WriteLine("Escribe el numero");
                    sw.Flush();
                    lectura = Convert.ToInt32(sr.ReadLine());


                    if (lectura > 0 && lectura < 100 && !bloqueado)
                    {

                        sw.WriteLine("\nOK");
                        sw.Flush();
                        acum += lectura;
                    }
                    else if (lectura == 555 && !bloqueado)
                    {
                        sw.WriteLine("\nAcumulado: " + acum);
                        sw.Flush();
                    }
                    else if (lectura == 666 && !bloqueado)
                    {
                        sw.WriteLine("\nRESET");
                        acum = 0;
                        sw.Flush();
                    }
                    else
                    {
                        sw.WriteLine("\nNOK");
                        acum = 0;
                        bloqueado = true;
                        sw.Flush();
                    }
                }
                
                catch (FormatException error)
                {
                    bloqueado = true;
                    sw.WriteLine("\nNOK");
                    sw.Flush();
                    Console.WriteLine("Error: {0}", error.ToString());
                }
                catch (Exception error)
                {
         
                    Console.WriteLine("Error: {0}", error.ToString());
                }
            }
            ns.Close();
            cli.Close();
        }

    }
}
