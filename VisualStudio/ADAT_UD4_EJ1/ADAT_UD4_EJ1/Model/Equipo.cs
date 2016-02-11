using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADAT_UD4_EJ1.Model
{
    public class Equipo
    {[Key]
        public virtual string numSerie { get; set; }
        public virtual string tipo { get; set; }
        public virtual string descripcion { get; set; }
        public virtual string contraro { get; set; }
        public virtual string codEspec { get; set; }
        public virtual ICollection<Asistencia> asistencias { get; set; }
        public virtual Cliente cliente { get; set; }
        public virtual string codCliente { get; set; }

        public Equipo()
        {
            asistencias = new List<Asistencia>();
         
        }

    }
}
