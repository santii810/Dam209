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

namespace PRPS_Proyecto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue<int> baraja = new Queue<int>();
        Partida jugador;
        Partida banca ;
        StreamWriter sw;


        private static List<int> DesordenarLista(List<int> input)
        {
            List<int> ordList = input;
            List<int> desList = new List<int>();

            Random randNum = new Random();
            while (ordList.Count > 0)
            {
                int val = randNum.Next(0, ordList.Count - 1);
                desList.Add(ordList[val]);
                ordList.RemoveAt(val);
            }
            return desList;
        }
        private void resetCartas()
        {
            List<int> tmp = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                tmp.Add(2);
                tmp.Add(3);
                tmp.Add(4);
                tmp.Add(5);
                tmp.Add(6);
                tmp.Add(7);
                tmp.Add(8);
                tmp.Add(9);
                tmp.Add(11);
                for (int j = 0; j < 4; j++)
                {
                    tmp.Add(10);
                }
            }

            baraja.Clear();
            foreach (var item in DesordenarLista(tmp))
            {
                baraja.Enqueue(item);
            }

        }
        private void mostrarEstadoPartida(Partida tmp)
        {
            sw.WriteLine("Suma: \t\t\t Cartas:");
            sw.Write(tmp.suma + "\t\t\t");
            foreach (var item in tmp.cartas)
            {
                sw.Write(item + " ");
            }
            sw.WriteLine();

        }
        private void ManejarCliente(TcpClient cli)
        {
            resetCartas();
            string data;
            string respuesta = "";
            bool salir = false;
            NetworkStream ns = cli.GetStream();
            StreamReader sr = new StreamReader(ns);
            sw = new StreamWriter(ns);
            jugador = new Partida();
            banca = new Partida();

            try
            {
              //  data = sr.ReadLine();
               // Console.WriteLine(data);

                sw.WriteLine("Bienvenido, jugamos al BlackJack?");
                sw.Flush();
                //juega jugador
                do
                {
                    int carta = baraja.Dequeue();
                    sw.WriteLine("Carta: " + carta);
                    jugador.addCarta(carta);
                    if (jugador.suma < 21)
                    {
                        mostrarEstadoPartida(jugador);
                        sw.WriteLine("Escribe 'Fin' para plantarte");
                        sw.Flush();
                        respuesta = sr.ReadLine().ToUpper().Trim();
                    }
                    if (jugador.suma > 21)
                    {
                        sw.WriteLine("Te has pasado");
                        mostrarEstadoPartida(jugador);
                        salir = true;
                    }
                    if (jugador.suma == 21)
                    {
                        sw.WriteLine("BLACKJACK 21, has ganado!");
                        mostrarEstadoPartida(jugador);
                        salir = true;
                    }

                } while (!respuesta.Equals("FIN") && !salir);
                //juega banca
                // si el jugador se pasa o hace 21 la banca no jugara, pues ya ha ganado o perdido respectivamente
                if (!salir)
                {
                    sw.WriteLine("Juega la banca:");
                    do
                    {
                        int carta = baraja.Dequeue();
                        sw.WriteLine("Carta: " + carta);
                        banca.addCarta(carta);
                        mostrarEstadoPartida(banca);
                    } while (banca.suma < 16 || banca.suma < jugador.suma);

                    if (banca.suma > 21 || banca.suma < jugador.suma)
                    {
                        sw.WriteLine("--------------");
                        sw.WriteLine("Has ganado");
                        sw.WriteLine("--------------");
                    }
                    else
                    {
                        sw.WriteLine("--------------");
                        sw.WriteLine("Has perdido");
                        sw.WriteLine("--------------");
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: {0}", error.ToString());
            }
                        sw.Flush();
            ns.Close();
            cli.Close();
        }
        private void buttonStartServer_Click(object sender, EventArgs e)
        {
            TcpListener newsock = new TcpListener(IPAddress.Any, 2000);
            newsock.Start();
            Console.WriteLine("Esperando por cliente");

            while (true)
            {
                TcpClient cliente = newsock.AcceptTcpClient(); 
                Thread t = new Thread(() => this.ManejarCliente(cliente));
                t.Start();
            }
        }
    }
}
