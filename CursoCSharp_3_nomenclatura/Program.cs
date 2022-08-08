using System;

namespace CursoCSharp_3_nomenclatura
{
    class Program
    {

        private readonly string _estaEsMiCadena;

        static void Main(string[] args)
        {

            //Camel case 
            var estoEsUnaVariable = "Camel";

            //Pascal
            var EstoEsUnavariable = "Pascal";
        }

        //Bien
        public int SumaDosNumeros(int numeroUno,int numeroDos)
        {
            var resultado = numeroUno + numeroDos;

            return resultado;
        }

        //Mal
        public int Sumar(int a, int b)
        {
            var c = a + b;

            return c;

        }

    }
}
