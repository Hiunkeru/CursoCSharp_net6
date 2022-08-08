using CursoCSharp_2_introduccion_consultas_linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_5_clausula_join
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Libro> libros = Libro.GetLibros();
            List<LibroStats> librosStats = LibroStats.GetLibrosStats();

            var TitulosLibros = from l in libros
                                join s in librosStats on l.ISBN equals s.ISBN
                                select new
                                {
                                    TituloSeleccionado = l.Titulo,
                                    PaginasLibro = s.Paginas
                                };

            foreach (var item in TitulosLibros)
            {
                Console.WriteLine($"Titulo: {item.TituloSeleccionado} Paginas: {item.PaginasLibro}");
            }

            Console.ReadKey();

        }
    }
}
