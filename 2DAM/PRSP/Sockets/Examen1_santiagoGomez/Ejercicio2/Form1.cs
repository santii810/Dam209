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

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        int[] array1 = new int[10000];
        int[] array2 = new int[10000];
        Thread intercambio1;
        Thread intercambio2;
        Thread intercambio3;


        public Form1()
        {
            InitializeComponent();
        }
        private void rellena1()
        {
            for (int i = 0; i < 10000; i++)
            {

                array1[i] = 1;

            }

        }
        private void rellena2()
        {
            for (int i = 0; i < 10000; i++)
            {

                array2[i] = 20000 + i;

            }

        }
        private void circular()
        {
            int pos0 = array1[0];
            for (int i = 0; i < 9998; i++)
            {
                array1[i] = array1[i + 1];
            }
            array1[9999] = pos0;
            intercambio1.Abort();
            intercambio2.Abort();
            intercambio3.Abort();

        }
        private void intercambio()
        {
            //intercambia las posiciones impares de los arrays
            int tmp;
            for (int i = 1; i < 10000; i += 2)
            {
                tmp = array1[i];
                array1[i] = array2[i];
                array2[i] = tmp;
            }
        }
        private int suma(int[] array)
        {
            //suma todos los items del array introducido
            int acum = 0;
            foreach (int item in array)
            {
                acum += item;
            }
            return acum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //rellenamos los arrays
            Thread t1 = new Thread(this.rellena1);
            Thread t2 = new Thread(this.rellena2);
            t1.Start();
            t2.Start();

            //esperamos a que finalicen estos hilos
            t1.Join();
            t2.Join();

            Thread circular = new Thread(this.circular);
            circular.Priority = ThreadPriority.Highest;
            intercambio1 = new Thread(intercambio);
            intercambio2 = new Thread(intercambio);
            intercambio3 = new Thread(intercambio);

            //ejecutamos los 4 hilos consecutivamente
            circular.Start();
            intercambio1.Start();
            intercambio2.Start();
            intercambio3.Start();

            /*
            Esta es la otra opcion que implemente para que se pudiese ver en el papel del examen como abortar los hilos

            circular.Join();
            intercambio1.Abort();
            intercambio2.Abort();
            intercambio3.Abort();

            */

            textBox1.Text = "Suma array1: " + suma(array1) + ". Suma array2: " + suma(array2) + ".";

        }
    }
}
