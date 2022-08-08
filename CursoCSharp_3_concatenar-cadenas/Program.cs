using System;

namespace CursoCSharp_3_concatenar_cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string superheroe = "Superman";
            string procedencia = "Kripton";
            string superpoder = "super fuerza";

            string todosDatos = superheroe + " procede de " + procedencia + " y tiene " + superpoder;

            string todosDatosConcat = string.Concat(superheroe, " procede de ", procedencia, " y tiene ", superpoder);
            string todosDatosConcat2 = string.Concat(superheroe, superpoder);

            string todosDatosInterpolation = $"{superheroe} procede de {procedencia} y tiene {superpoder}";
            string ejemploInterpolacion = $"{ 3 + 5 } es igual a 8?";

            Console.WriteLine(todosDatos);
            Console.ReadLine();

            Console.WriteLine(todosDatosConcat);
            Console.WriteLine(todosDatosConcat2);
            Console.ReadLine();

            Console.WriteLine(todosDatosInterpolation);
            Console.ReadLine();

            Console.WriteLine(ejemploInterpolacion);
            Console.ReadLine();

        }
    }
}
