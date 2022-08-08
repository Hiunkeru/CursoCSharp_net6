using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_2_introduccion_consultas_linq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Libro> libros = Libro.GetLibros();

            var titulosLibros =
                from l in libros
                select l.Titulo;

            foreach (var titulo in titulosLibros)
            {
                Console.WriteLine(titulo);
            }

            Console.ReadKey();
        }
    }
}
