using System;

namespace CursoCSharp_12_leyendo_argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hay " + args.Length + " elementos");

            foreach (var argumentos in args)
            {
                Console.WriteLine(argumentos);
            }

        }
    }
}
