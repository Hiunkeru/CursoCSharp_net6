using System;
using static System.Convert;

namespace CursoCSharp_14_conversiones_tipo
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Hola";
            int numero = 12;

            cadena = numero.ToString();

            //Implicitos
            int numeroEntero = 34543;
            long numeroLong = numeroEntero;

            //Explicitos
            double numeroDouble = 12.56;
            int numeroEnteroDouble = (int)numeroDouble;
            Console.WriteLine(numeroEnteroDouble);

            //definidos por el usuario

            //Con clases de asistentes



            double doubleValor = 8.45;
            int enteroValor = ToInt32(doubleValor);
            Convert.ToInt32(doubleValor);
 
        }
    }
}
