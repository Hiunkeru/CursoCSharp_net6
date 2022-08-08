using CursoCSharp_2_introduccion_consultas_linq;
using CursoCSharp_5_clausula_join;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_6_clausula_let
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Libro> libros = Libro.GetLibros();
            List<LibroStats> librosStats = LibroStats.GetLibrosStats();

            var TitulosLibros = from l in libros
                                join s in librosStats on l.ISBN equals s.ISBN
                                let ganancias = (l.Precio * s.Ventas)
                                select new
                                {
                                    TituloSeleccionado = l.Titulo,
                                    Ganancias = ganancias
                                };

            foreach (var item in TitulosLibros)
            {
                Console.WriteLine($"Titulo: {item.TituloSeleccionado} Ganancias: {item.Ganancias}");
            }

            Console.ReadKey();

        }
    }
}
