using System;

namespace CursoCSharp_15_sobrecarga_operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto punto = new Punto(200, 50);

            punto = +punto;

            Console.WriteLine($" X = {punto.X} Y = {punto.Y}");

            punto = +punto;
            punto = +punto;
            punto = +punto;

            Console.WriteLine($" X = {punto.X} Y = {punto.Y}");

            punto = -punto;

            Console.WriteLine($" X = {punto.X} Y = {punto.Y}");
        }
    }
}
