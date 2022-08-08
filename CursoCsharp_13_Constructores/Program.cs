using System;

namespace CursoCsharp_13_Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto punto = new Punto();

            Console.WriteLine($"X = {punto.X} Y = {punto.Y}");

            Punto punto2 = new Punto(10,20);

            Console.WriteLine($"X = {punto2.X} Y = {punto2.Y}");

            Punto punto3 = new Punto(10);

            Console.WriteLine($"X = {punto3.X} Y = {punto3.Y}");
        }
    }
}
