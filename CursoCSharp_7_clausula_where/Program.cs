using CursoCSharp_2_introduccion_consultas_linq;
using CursoCSharp_5_clausula_join;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_7_clausula_where
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Libro> libros = Libro.GetLibros();
            List<LibroStats> librosStats = LibroStats.GetLibrosStats();

            var TitulosLibros = from l in libros
                                join s in librosStats on l.ISBN equals s.ISBN
                                where s.Ventas > 1000
                                select new
                                {
                                    Nombre = l.Titulo,
                                    VentasLibro = s.Ventas
                                };

            var TitulosLibros2 = from l in libros
                                 join s in librosStats on l.ISBN equals s.ISBN
                                 where s.Ventas > 1000
                                 where l.FechaSalida > DateTime.Now.AddYears(-2)
                                 select new
                                 {
                                     Nombre = l.Titulo,
                                     VentasLibro = s.Ventas
                                 };


            Console.ReadKey();

        }
    }
}
