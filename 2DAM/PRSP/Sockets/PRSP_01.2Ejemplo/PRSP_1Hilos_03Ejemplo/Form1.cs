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


namespace PRSP_1Hilos_03Ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] numeros = new int[1000];
        int iterador = 0;
        int numero = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(rellena);
            Thread t2 = new Thread(rellena);
            Thread t3 = new Thread(rellena);
            Thread t4 = new Thread(rellena);
            Thread t5 = new Thread(rellena);
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();

            //esperar fin de ejecucion de los hilos
            //Thread.Sleep(10000);
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();




            //leer array
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }

        }
        object o = new object();
        private void rellena()
        {
            for (int i = 0; i < 200; i++)
            {
                lock (o)
                {
                    numero++;
                    numeros[iterador] = numero;
                    Thread.Sleep(10);
                    iterador++;
                }
            }
        }
        private void rellenaM()
        {
            for (int i = 999; i > 0; i--)
            {
                numeros[i] = i;
                //Thread.Sleep(5);
            }
            lock (this)
            Monitor.Pulse(this);
        }
        private void escribeM()
        {

            Monitor.Wait(this);
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(this.rellenaM);
            Thread t2 = new Thread(this.escribeM);
            t1.Start();
            t2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(this.ping);
            Thread t2 = new Thread(this.pong);
            t1.Start();
            t2.Start();
        }
        object o1 = new object();
        object o2 = new object();

        private void ping()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (o2)
                    Monitor.Pulse(o2);
                lock (o1)
                {
                    Console.WriteLine("ping");
                    Monitor.Wait(o1);
                }
            }
        }
        private void pong()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (o1)
                    Monitor.Pulse(o1);
                lock (o2)
                {
                    Console.WriteLine("PONG");
                    Monitor.Wait(o2);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread[] t = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                t[i] = new Thread(this.rellena);
                t[i].IsBackground = true;
                t[i].Start();
            }
            t[0].Abort();
            if (t[0].IsAlive)

                Console.WriteLine("t0 VIIIVE");
            else
                Console.WriteLine("RIP t0");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text = "Hola desde el hilo principal";
            this.escribirTextBox();
            Thread t = new Thread(this.escribirTextBox);
            t.Start();

        }
        private void escribirTextBox()
        {
            this.textBox1.Text = "Hola desde el hilo principal";

        }
        private void escribirTextBoxParametros(string s)
        {
            this.textBox1.Text = s;

        }
        delegate void DelegadoEscribeTextBox();
        delegate void DelegadoEscribeTextBoxParametros(string s);
        private void RellenaTextBox()
        {
            //necesitamos un delegado por que el hilo principal esta atento a la escucha de eventos
            DelegadoEscribeTextBox d1 = new DelegadoEscribeTextBox(this.escribirTextBox);
            this.Invoke(d1); 
            //invocacion al delegado con parametros
            DelegadoEscribeTextBoxParametros d2 = new DelegadoEscribeTextBoxParametros(this.escribirTextBoxParametros);
            this.Invoke(d2, "hola con parametros");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text = "Hola desde el hilo principal";
            this.escribirTextBox();
            Thread t = new Thread(this.RellenaTextBox);
            t.Start();
        }
    }
}
