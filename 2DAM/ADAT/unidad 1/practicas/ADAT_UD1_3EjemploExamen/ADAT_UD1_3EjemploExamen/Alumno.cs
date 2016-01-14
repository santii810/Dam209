using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD1_3EjemploExamen
{
    class Alumno
    {
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string NombreModulo { get; set; }
        public int HorasFaltadas { get; set; }
        public double PorcentajeFaltas { get; set; }


        public void calcularPorcentajeFaltas(int horasTotales)
        {
            this.PorcentajeFaltas = Math.Round((double) HorasFaltadas / horasTotales *100,2);
        }

    }
}
