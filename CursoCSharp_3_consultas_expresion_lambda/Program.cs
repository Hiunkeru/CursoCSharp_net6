using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_3_consultas_expresion_lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Libro> libros = Libro.GetLibros();

            //usando consultas linq
            var linq = from l in libros
                       select l.Titulo;

            //usando expresiones lambda
            var titulos = libros.Select(x => x.Titulo);
            var titulos2 = libros.Select(y => y.Titulo);

            var ISBNs = libros.Select(x => x.ISBN);

            var fechaSalida = libros.Where(x => x.FechaSalida > DateTime.Now.AddYears(-2))
                .Select(x => x.Titulo);

            var tituloCorto = libros.Where(x => x.Titulo.Length < 10)
                .Select(x => x.Titulo);

            var claseAnonima = libros.Select(x => 
            new{
                Titulo2 = x.Titulo,
                FechaAuxiliar = x.FechaSalida,
                PropiedadInventad = "valor inventado"
            });

            foreach (var item in claseAnonima)
            {
                Console.WriteLine($"valor titulo2 : {item.Titulo2} valor fecha: {item.FechaAuxiliar} valor inventado: {item.PropiedadInventad}");
            }

            Console.ReadKey();
        }
    }
}
