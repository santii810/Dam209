using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD1_Ejer3_Test
{
    class Alumno
    {
        public string nombre;
        public List<Pregunta> examen = new List<Pregunta>();
        public int preguntasAcertadas;
        public int preguntasFalladas;
        public int preguntasTotales;



        public Alumno(string nombre, Dictionary<int, char> respuestas, Dictionary<int, char> respuestasCorrectas, int preguntasTotales)
        {
            this.nombre = nombre;
            foreach (int item in respuestas.Keys)
            {
                if (!respuestas[item].Equals(null))
                examen.Add(new Pregunta(item, respuestasCorrectas[item], respuestas[item]));
            }
            calificar(preguntasTotales);
            
        }

        public void calificar(int preguntasTotales)
        {
            this.preguntasAcertadas = 0;
            this.preguntasFalladas = 0;
            this.preguntasTotales = preguntasTotales;
            foreach (Pregunta item in this.examen)
            {
                if (item.acertada)
                    preguntasAcertadas++;
                else
                    preguntasFalladas++;
            }
        }
    }
}
