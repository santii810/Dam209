using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADAT_UD4_EJ1.Model
{
    public class Asistencia
    {

        public virtual string asistenciaID { get; set; }
        public virtual DateTime fechaHoraInicio { get; set; }
        public virtual DateTime fechaHoraFin { get; set; }
        public virtual string descripcion { get; set; }
        public virtual Equipo equipo { get; set; }
        public virtual string numSerie { get; set; }
        public virtual Contacto contacto { get; set; }
        public virtual string contactoId { get; set; }
        public virtual Usuario usuario { get; set; }
        public virtual string usuarioId { get; set; }
        public virtual Incidencia   incidencia { get; set; }
        public virtual string numeroINC { get; set; }

        public Asistencia()
        {
        }

    }
}
