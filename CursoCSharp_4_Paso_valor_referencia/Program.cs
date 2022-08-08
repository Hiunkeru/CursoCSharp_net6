using System;

namespace CursoCSharp_4_Paso_valor_referencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 25;

            //Console.Write(numero1);

            //CambiarPorValor(numero1);

            //Console.Write(numero1);

            //CambiarPorReferencia(ref numero1);

            //Console.Write(numero1);

            int numero2 = 55;

            Devuelve2ValoresPorReferencia(ref numero1, ref numero2);

            Console.Write(numero1 + " " + numero2);
        }
        
        //paso por valor
        public static void CambiarPorValor(int numero)
        {
            numero = 10;
        }

        //paso por referencia
        public static void CambiarPorReferencia(ref int numero)
        {
            numero = 10;
        }

        //funcion que devuelve 2 valores
        public static void Devuelve2ValoresPorReferencia(ref int numero1,ref int numero2)
        {
            numero1 = 10;
            numero2 = 20;
        }
    }
}
