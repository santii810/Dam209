using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD1_3XML_Ejer1_XML_DOM
{
    class Libro
    {
        public string isbn { get; set; }
        public string nombreAutor { get; set; }
        public string apellidosAutor { get; set; }
        public string titulo { get; set; }
        public int numEjemplares { get; set; }
        public string codigo { get; set; }

        public Libro() { }
        public Libro(string Codigo, string Isbn, string titulo, string autor, string apellidos, int ejemplares)
        {
            this.codigo = Codigo;
            this.isbn = Isbn;
            this.titulo = titulo;
            this.nombreAutor = autor;
            this.apellidosAutor = apellidos;
            this.numEjemplares = ejemplares;
        }
    }
}
