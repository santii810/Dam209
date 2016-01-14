using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADATA_UD1_5Meteogalicia
{
    class Meteo
    {
        public Lectura velocidadeVento { get; set; }
        public Lectura direccionVento { get; set; }
        public Lectura temparaturaMedia { get; set; }
        public Lectura chuvia { get; set; }
        public Lectura refacho { get; set; }
        public Lectura horasSol { get; set; }
    }
}
