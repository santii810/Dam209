using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DINT_Examen
{
    public class Datos
    {
        public string apellido1;
        public string apellido2;
        public string nombre;
        public string DNI;
        public string direccion;


        public Datos(string apellido1, string apellido2, string nombre, string DNI, string direccion)
        {
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.nombre = nombre;
            this.DNI = DNI;
            this.direccion = direccion;
        }


    }
}
