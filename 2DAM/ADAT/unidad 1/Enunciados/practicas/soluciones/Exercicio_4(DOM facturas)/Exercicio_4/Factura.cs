using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Factura
    {
        private int numero;
        private string codClient;
        private string nameClient;
        private string dirClient;
        private int tlfClient;
        private List<Producto> products;
        private DateTime fecha;

        public Factura(int numero, string codClient, string nameClient, string dirClient, int tlfClient, List<Producto> products, DateTime fecha)
        {
            this.numero = numero;
            this.codClient = codClient;
            this.nameClient = nameClient;
            this.dirClient = dirClient;
            this.tlfClient = tlfClient;
            this.products = products;
            this.fecha = fecha;
        }
        public Factura()
        {
            products = new List<Producto>();
        }
        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string CodClient
        {
            get
            {
                return codClient;
            }

            set
            {
                codClient = value;
            }
        }

        public string NameClient
        {
            get
            {
                return nameClient;
            }

            set
            {
                nameClient = value;
            }
        }

        public string DirClient
        {
            get
            {
                return dirClient;
            }

            set
            {
                dirClient = value;
            }
        }

        public int TlfClient
        {
            get
            {
                return tlfClient;
            }

            set
            {
                tlfClient = value;
            }
        }

        internal List<Producto> Products
        {
            get
            {
                return products;
            }

            set
            {
                products = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }
    }
}
