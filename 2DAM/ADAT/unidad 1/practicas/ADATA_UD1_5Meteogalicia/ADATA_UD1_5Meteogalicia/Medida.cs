using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADATA_UD1_5Meteogalicia
{
    class Medida
    {
        public int id { get; set; }
        public string variable { get; set; }
        public string unidades { get; set; }
        public double valor { get; set; }
        public int codigoValidacion { get; set; }
    }
}
