using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD4_EJ1.Model
{
    public class Visita
    {
        [Key]
        public virtual DateTime fechaHoraEfecto { get; set; }
        public virtual string descripcion { get; set; }

        public Visita()
        {

        }
    }
}
