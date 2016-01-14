using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD1_2XML_Ejer4_Factura
{
    class Factura
    {
        public Cliente cliente { get; set; }
        public List<Producto> productos { get; set; }
    }
}
