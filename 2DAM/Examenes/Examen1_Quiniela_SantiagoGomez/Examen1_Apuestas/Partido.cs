using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_Apuestas
{
    class Partido
    {
        public int id { get; set; }
        public string equipoLocal { get; set; }
        public string equipoVisitante { get; set; }
        public string resultado { get; set; }
    }
    class Categoria
    {
        public int id { get; set; }
        public int aciertosNecesarios { get; set; }
        public int porcentajePremio { get; set; }
        public int acertantes { get; set; } = 0;
    }
    class Apuesta
    {
        public int id { get; set; }
        public string pronostico { get; set; }
        public string resultado { get; set; }
        public bool acertado { get; }

        public Apuesta(string id, string pronostico, List<Partido> partidos)
        {
            this.id = Convert.ToInt32(id);
            this.pronostico = pronostico;
            this.resultado = partidos.Where(i => i.id == this.id).First().resultado;
            if (pronostico.Equals(resultado))
                acertado = true;
            else
                acertado = false;
        }
    }

    class Pronostico
    {
        public int id { get; set; }
        public List<Apuesta> apuestas { get; set; } = new List<Apuesta>();
        public int aciertos { get; set; } = 0;

        public void addApuesta(Apuesta tmp)
        {
            apuestas.Add(tmp);
            if (tmp.acertado)
                aciertos++;
        }
    }

    class Premios
    {
        public string Categoria { get; set; }
        public int Aciertos { get; set; }
        public int Porcentaje { get; set; }
        public int Cuantia { get; set; }
        public int Acertantes { get; set; }
        public int PremioUnitario { get; set; }
    }
}
