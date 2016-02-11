using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADAT_UD4_EJ1.Model
{
    public class Incidencia
    {
        [Key]
        public virtual int numeroINC { get; set; }
        public virtual DateTime fechaHoraInicio { get; set; }
        public virtual DateTime fechaHoraFin { get; set; }
        public virtual int numAsis { get; set; }
        public virtual bool concluido { get; set; }

        public virtual ICollection<Asistencia> asistencias { get; set; }
        public Incidencia()
        {
            asistencias = new List<Asistencia>();

        }

    }
}
