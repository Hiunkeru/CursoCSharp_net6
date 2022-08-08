using System;

namespace CursoCSharp_5_enumerados
{
    class Program
    {
        static void PrintColor(Color color)
        {
            switch (color)
            {
                case Color.Rojo:
                    Console.WriteLine("Rojo");
                    break;
                case Color.Verde:
                    Console.WriteLine("Verde");
                    break;
                case Color.Azul:
                    Console.WriteLine("Azul");
                    break;
                default:
                    Console.WriteLine("Unknown color");
                    break;
            }
        }

        static void Main(string[] args)
        {

            Color c = Color.Rojo;
            PrintColor(c);
            PrintColor(Color.Azul);

            int i = (int)Color.Azul;     // int i = 2;
            Color c2 = (Color)2;         // Color c = Color.Azul;  

            var alineacion = Alignment.Left.ToString();

        }
    }
}
