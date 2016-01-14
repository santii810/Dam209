using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRPS_Proyecto1
{
    class Partida
    {
        public int suma { get; set; } = 0;
        public List<int> cartas { get; set; } = new List<int>();


        public void addCarta(int carta)
        {
            cartas.Add(carta);
            suma += carta;
        }
    }
}
