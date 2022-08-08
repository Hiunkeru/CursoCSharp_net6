using System;

namespace CursoCSharp_12_depuracion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 15;
            int num2 = 20;

            int suma = Suma(num1, num2);
            int multiplicacion = Multiplicacion(num1, num2);

        }

        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
