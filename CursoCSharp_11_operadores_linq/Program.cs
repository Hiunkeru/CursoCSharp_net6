using CursoCSharp_10_clausula_groupby;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_11_operadores_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = Libro.GetLibros();


            //Operadores matematicos

            var count = libros.Count();

            var suma = libros.Sum(x => x.Precio);

            var maximo = libros.Max(x => x.Precio);

            var minimo = libros.Min(x => x.Precio);

            var media = libros.Average(x => x.Precio);

            //operadores miembro

            var toma = libros.Take(2);

            var salta = libros.Skip(5);

            var tomaYSalta = libros.Skip(2).Take(3);

            var vuelta = libros.Reverse<Libro>();

            var primero = libros.Where(x=> x.Titulo.Length > 0).OrderBy(x=> x.Precio).First();

            var primeroONulo = libros.FirstOrDefault();

            var elementoEn = libros.ElementAt(4);

            var ultimo = libros.Last();

            var single = libros.Single(x => x.ISBN.Contains("22"));

            var alguno = libros.Any();

            var condicionTodos = libros.All(x => x.Titulo.Length > 0);

            var contiene = libros.Contains(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-3),
                ISBN = "111111",
                Precio = 12.22M,
                Titulo = "El señor de los anillos"
            });



        }
    }
}
