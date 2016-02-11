using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD4_EJ1.Model
{
    public class Tarea
    {

        public virtual string tareaId { get; set; }
        public virtual DateTime horaInicio { get; set; }
        public virtual DateTime FechaInicio { get; set; }
        public virtual int prioridad { get; set; }
        public virtual string descripcion { get; set; }
        public virtual bool concluido { get; set; }
        public virtual bool propia { get; set; }
        public virtual int progreso { get; set; }
        public virtual Usuario usuario { get; set; }
        
        public Tarea()
        {

        }

    }
}
