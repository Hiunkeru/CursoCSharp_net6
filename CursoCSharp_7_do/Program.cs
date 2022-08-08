using System;

namespace CursoCSharp_7_do
{
    class Program
    {
        static void Main(string[] args)
        {
            //do
            //{
            //    //Instrucciones
            //} while (true);

            int numero = 0;

            do
            {
                Console.Write(numero);
                numero++; //numero = numero + 1;

                if(numero == 5)
                {
                    return;
                }

            }
            while (numero < 10);

        }
    }
}
