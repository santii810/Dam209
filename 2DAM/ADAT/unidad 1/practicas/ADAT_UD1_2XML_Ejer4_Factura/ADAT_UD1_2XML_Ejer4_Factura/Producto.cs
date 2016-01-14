using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD1_2XML_Ejer4_Factura
{
    class Producto
    {
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public double totalDeLinea { get; set; }


        public Producto(string codigo, string descripcion, int cantidad, double precio)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precio = precio;
            this.totalDeLinea = cantidad * precio;
        }
    }
}
