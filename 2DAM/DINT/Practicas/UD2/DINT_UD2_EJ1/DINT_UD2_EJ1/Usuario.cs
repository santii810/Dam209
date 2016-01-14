using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DINT_UD2_EJ1
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        
        public Usuario (string nombre, string apellidos, string password, string email, string direccion)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.password = password;
            this.email = email;
            this.direccion = direccion;
        }
    }
}
