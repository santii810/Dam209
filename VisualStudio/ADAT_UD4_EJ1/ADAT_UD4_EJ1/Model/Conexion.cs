using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD4_EJ1.Model
{
    public class Conexion
    {

        public virtual string conexionId { get; set; }
        public virtual string parametro { get; set; }
        public virtual string valor { get; set; }

        public Conexion()
        {

        }
    }
}
