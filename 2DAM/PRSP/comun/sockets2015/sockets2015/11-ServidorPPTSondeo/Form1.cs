using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;

namespace _11_ServidorPPTSondeo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string jugador1 = "";
        string idJug1 = "";
        string jugada1 = "";
        string jugador2 = "";
        string idJug2 = "";
        string jugada2 = "";
        int puntos1 = 0;
        int puntos2 = 0;
        int numJugada = 1;

        string[] textoVueltaJugada = new string[100];
        private void ManejarCliente(TcpClient cli)
        {
            string data;
            NetworkStream ns = cli.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            sw.WriteLine("#INSCRIBIR#nombre#");
            sw.WriteLine("#JUGADA#{piedra/papel/tijera}#");
            sw.WriteLine("#RESULTADOJUGADA#numeroJugada");
            sw.WriteLine("#PUNTUACION#");
            sw.Flush();
            while (true)
            {
                try
                {
                    data = sr.ReadLine();
                    Console.WriteLine(data); //para depuración es server
                    String[] subdatos = data.Split('#');
                    #region comINSCRIBIR
                    if (subdatos[1] == "INSCRIBIR")
                    {
                        if (jugador1 == "")
                        {
                            jugador1 = subdatos[2];
                            idJug1 = cli.Client.RemoteEndPoint.ToString();
                            sw.WriteLine("#OK#");
                            sw.Flush();
                        }
                        else if (jugador2 == "")
                        {
                            jugador2 = subdatos[2];
                            idJug2 = cli.Client.RemoteEndPoint.ToString();
                            sw.WriteLine("#OK#");
                            sw.Flush();
                        }
                        else
                        {
                            sw.WriteLine("#NOK#ya hay dos jugadores");
                            sw.Flush();
                        }
                    }
                    #endregion
                    #region comJUGADA
                    if (subdatos[1] == "JUGADA")
                    {
                        if ((subdatos[2] != "piedra") && (subdatos[2] != "papel") && (subdatos[2] != "tijera"))
                        {
                            sw.WriteLine("#NOK#valores válidos: piedra/papel/tijera#");
                            sw.Flush();
                        }
                        //comprobamos quien hace jugada y la guardamos
                        if (idJug1 == cli.Client.RemoteEndPoint.ToString() ||
                            idJug2 == cli.Client.RemoteEndPoint.ToString())
                        {
                            if (idJug1 == cli.Client.RemoteEndPoint.ToString())
                            {
                                jugada1 = subdatos[2];                             
                            }
                            else if (idJug2 == cli.Client.RemoteEndPoint.ToString())
                            {
                                jugada2 = subdatos[2];
                            }
                            sw.WriteLine("#OK#" + numJugada + "#");
                            sw.Flush();

                            //compruebo si tengo emitidas el par de jugadas
                            if (jugada1 != "" && jugada2 != "")
                            {
                                ComprobarGanador();
                            }  
                        }
                        else
                        {
                            sw.WriteLine("#NOK#jugador no en partida#");
                            sw.Flush();
                        }
                    }
                    #endregion
                    #region comRESULTADOJUGADA
                    if (subdatos[1] == "RESULTADOJUGADA")
                    {
                        int numJugadaCiente = System.Convert.ToInt32(subdatos[2]);
                        if ((numJugadaCiente < numJugada) &&
                            (numJugadaCiente > 0))
                        {
                            sw.WriteLine(textoVueltaJugada[numJugadaCiente-1]);
                            sw.Flush();
                        }
                        else
                        {
                            sw.WriteLine("#NOK#numero de jugada no valida#");
                            sw.Flush();
                        }

                    }
                    #endregion
                    #region comPUNTUACION
                    if (subdatos[1] == "PUNTUACION")
                    {
                        sw.WriteLine("#OK#" + jugador1 + ":" + puntos1.ToString() + "#"
                                            + jugador2 + ":" + puntos2.ToString() + "#");
                        sw.Flush();
                    }
                    #endregion


                }
                catch (Exception error)
                {
                    Console.WriteLine("Error: {0}", error.ToString());
                    break;
                }
            }
            ns.Close();
            cli.Close();
        }

        private void ComprobarGanador()
        {
            //resolvemos la jugada
            if ((jugada1 == "piedra" && jugada2 == "piedra") ||
                (jugada1 == "papel" && jugada2 == "papel") ||
                (jugada1 == "tijera" && jugada2 == "tijera"))
            {
                textoVueltaJugada[numJugada - 1] = "#OK#empate#";
            }
            else if ((jugada1 == "piedra" && jugada2 == "tijera") ||
                (jugada1 == "tijera" && jugada2 == "papel") ||
                (jugada1 == "papel" && jugada2 == "piedra"))
            {
                textoVueltaJugada[numJugada - 1] = "#OK#ganador:" + jugador1 + "#";              
                puntos1++;               
            }
            else if ((jugada2 == "piedra" && jugada1 == "tijera") ||
                (jugada2 == "tijera" && jugada1 == "papel") ||
                (jugada2 == "papel" && jugada1 == "piedra"))
            {
                textoVueltaJugada[numJugada - 1] = "#OK#ganador:" + jugador2 + "#";
                puntos2++;            
            }
            numJugada++;
            jugada1 = "";
            jugada2 = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TcpListener newsock = new TcpListener(IPAddress.Any, 2000);
            newsock.Start();

            Console.WriteLine("Esperando por cliente");

            while (true)
            {
                TcpClient cliente = newsock.AcceptTcpClient(); //linea bloqueante
                Thread t = new Thread(() => this.ManejarCliente(cliente));
                //t.IsBackground = true;
                t.Start();
            }
        }
    }
}
