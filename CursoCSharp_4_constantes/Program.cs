using System;

namespace CursoCSharp_4_constantes
{
    class Program
    {
        public const string NOMBRE = "Pedro";
        public const int NUMERO_PEDIDOS_MAXIMOS = 10;

        static void Main(string[] args)
        {
            //Esto no se puede hacer
            //NUMERO_PEDIDOS_MAXIMOS = 12;

            for (int i = 0; i < 12; i++)
            {
                if(i < NUMERO_PEDIDOS_MAXIMOS)
                {
                    Console.Write(i);
                }
            }

        }
    }
}
