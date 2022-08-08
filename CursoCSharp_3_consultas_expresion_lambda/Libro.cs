using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_3_consultas_expresion_lambda
{
    public class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaSalida { get; set; }

        public static List<Libro> GetLibros()
        {
            List<Libro> libros = new List<Libro>();

            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-3),
                ISBN = "111111",
                Precio = 12.22M,
                Titulo = "El señor de los anillos"
            });

            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-2),
                ISBN = "222222",
                Precio = 18.15M,
                Titulo = "El origen perdido"
            });

            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-5),
                ISBN = "3333333",
                Precio = 22.49M,
                Titulo = "La catredal del mar"
            });

            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-3),
                ISBN = "44444444",
                Precio = 8.35M,
                Titulo = "Eragon"
            });

            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-1),
                ISBN = "55555555",
                Precio = 32.28M,
                Titulo = "Juego de Tronos"
            });

            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-1),
                ISBN = "6666666",
                Precio = 15.65M,
                Titulo = "Insulgente"
            });

            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddMonths(-3),
                ISBN = "777777777",
                Precio = 25.37M,
                Titulo = "El ocho"
            });

            return libros;
        }
    }
}
