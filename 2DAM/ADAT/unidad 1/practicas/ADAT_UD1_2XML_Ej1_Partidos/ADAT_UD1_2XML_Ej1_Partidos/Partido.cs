using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD1_2XML_Ej1_Partidos
{
    public class Partido
    {
        public int idEquipoLocal { get; set; }
        public string equipoLocal { get; set; }
        public int golesLocal { get; set; }
        public int golesVisitante { get; set; }
        public int idEquipoVisitante { get; set; }
        public string equipoVisitante { get; set; }

        public Partido() { }
        public Partido(int idEquipoLocal, string equipoLocal, int idEquipoVisitante, string equipoVisitante)
        {
            this.idEquipoLocal = idEquipoLocal;
            this.idEquipoVisitante = idEquipoVisitante;
            this.equipoLocal = equipoLocal;
            this.equipoVisitante = equipoVisitante;
        }
    }
}
