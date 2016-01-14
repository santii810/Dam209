using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficheros1
{
    class Frases
    {
        public string Frase { get; set; }
        public string Autor { get; set; }


        public Frases(string linea)
        {
            string[] partes = new string[2];
            partes = linea.Split('-');
            this.Frase = partes[0].Trim();
            this.Autor = partes[1].Trim();
        }

    }
}
