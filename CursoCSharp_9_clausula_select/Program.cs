using CursoCSharp_2_introduccion_consultas_linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_9_clausula_select
{

    public class Categoria
    {
        public string Titulo { get; set; }
        public string IdLibro { get; set; }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = Libro.GetLibros();

            var tituloLibros = from l in libros
                               select l.Titulo;

            var ejemplo2 = from l in libros
                           select new Categoria { IdLibro = l.ISBN, Titulo = l.Titulo };

            var ejemplo3 = from l in libros
                           where l.FechaSalida > DateTime.Now.AddMonths(-6)
                           select l;

            var ejemplo4 = from l in libros
                           select new { ISBN = l.ISBN, ISBNAux = "wqr-" + l.ISBN };

            var ejemplo5 = from l in libros
                           select new { ISBN = l.ISBN, Lanzado = (l.FechaSalida < DateTime.Now ? "En venta" : "En breve") };

        }
    }
}
