using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD1_Ejer3_Test
{
    class Pregunta
    {
        int numero;
        char respuestaCorrecta;
        char respuestaAlumno;
        public bool acertada;

        public Pregunta(int numero, char respuestaCorrecta, char respuestaAlumno)
        {
            this.numero = numero;
            this.respuestaAlumno = respuestaAlumno;
            this.respuestaCorrecta = respuestaCorrecta;
            if (this.respuestaCorrecta == this.respuestaAlumno)
                this.acertada = true;
            else
                this.acertada = false;
        }
    }
}
