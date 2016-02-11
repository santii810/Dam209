using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD4_EJ1.Model
{
    public class Contacto
    {
        public virtual string contactoId { get; set; }
        public virtual string nombre { get; set; }
        public virtual string telefono { get; set; }
        public virtual string email { get; set; }
        public virtual ICollection<Asistencia> asistencias { get; set; }
        public Contacto()
        {
            asistencias = new List<Asistencia>();
        }
    }
}
