using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD1_2XML_Ejer4_Factura
{
    class Cliente
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Fecha { get; set; }
        public string Telefono { get; set; }
        public Cliente(string codigo, string nombre, string direccion, string fecha, string telefono)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Fecha = fecha;
            this.Telefono = telefono;
        }
    }
}
