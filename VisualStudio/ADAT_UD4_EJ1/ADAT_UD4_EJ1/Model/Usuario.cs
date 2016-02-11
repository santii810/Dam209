using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADAT_UD4_EJ1.Model
{
    public class Usuario
    {
        public virtual string usuarioId { get; set; }
        public virtual string nombre { get; set; }
        public virtual string password { get; set; }
        public virtual int numTecnico { get; set; }
        public virtual string tipo { get; set; }
        public virtual string correo { get; set; }
        public virtual int ventanas { get; set; }
        public virtual ICollection<Tarea> tareas { get; set; }
        public virtual ICollection<Asistencia> asistencias { get; set; }
        public Usuario()
        {
            tareas = new List<Tarea>();
            asistencias = new List<Asistencia>();
        }

    }
}
