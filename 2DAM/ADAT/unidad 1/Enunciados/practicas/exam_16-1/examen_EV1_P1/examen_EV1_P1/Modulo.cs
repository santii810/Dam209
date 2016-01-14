using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_EV1_P1
{
   public  class Modulo
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int horasTotales{ get; set; }
        public int horasFaltadas{ get; set; }
       
    }
   public class Alumno {
       public string Nombre { get; set; }
       public string NombreModulo  { get; set; }
       public int horasFaltadas { get; set; }
       public double porcentajeFaltas { get; set; }
   
   }
}
