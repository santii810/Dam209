using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADAT_UD4_EJ1.Model
{
    public class Cliente
    {
        [Key]
        public virtual int codCliente { get; set; }
        public virtual string nombre { get; set; }
        public virtual string descripcion { get; set; }
        public virtual string tipo { get; set; }
        public virtual string correo { get; set; }
        public virtual int codPostal { get; set; }
        public virtual ICollection<Equipo> equipos { get; set; }
        
        public Cliente()
        {
            equipos = new List<Equipo>();
        }

    }
}
