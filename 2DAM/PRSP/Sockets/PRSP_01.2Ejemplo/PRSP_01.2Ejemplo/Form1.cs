using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRSP_01._2Ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(Go));
            t.Start(); // Run Go() on the new thread.
            Go(); // Simultaneously run Go() in the main thread.


        }
        static void Go()
        {
            Console.WriteLine("hello!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //referencia pagina 4
            Thread t = new Thread(WriteY); // Kick off a new thread
            t.Start(); // running WriteY()
                       // Simultaneously, do something on the main thread.
            for (int i = 0; i < 1000; i++) Console.Write("x");

        }
        private void WriteY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            feito = false;
            Thread t = new Thread(this.goFeito);
            t.Start();
            goFeito();
        }
        bool feito;
        private void goFeito()
        {
            if (!feito)
            {
                Console.WriteLine("Hola, hecho");
                feito = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //primera forma de pasar parametros

            Thread t1 = new Thread(() => this.mensaje("Marina"));
            t1.Start();
            //pasar parametros despues de la definicion
            Thread t2 = new Thread(this.mensaje);


            this.mensaje("Amanda");
        }

        private void mensaje(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }

        private void mensaje(object nombre)
        {
            Console.WriteLine("Hola " + nombre);
            string s = (string)nombre;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(this.WriteY);
            t.Priority = ThreadPriority.Highest;
            Thread.CurrentThread.Priority = ThreadPriority.Lowest;

            t.Start();
            for (int i = 0; i < 10000; i++)
            {
                Console.Write("X");
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(this.nombreThreads);
            Thread t2 = new Thread(this.nombreThreads);
            t1.Name = "Primero";
            t2.Name = "Segundo";
            t1.Start();

            t2.Start();
        }
        private void nombreThreads()
        {
            Console.WriteLine("**********" + Thread.CurrentThread.Name);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Thread t = new Thread(this.goLargo);
            t.IsBackground = true;
            t.Start();
        }

        private void goLargo()
        {
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("hola");
            }
        }
    }

}
