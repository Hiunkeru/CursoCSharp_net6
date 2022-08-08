using System;

namespace CursoCSharp_3_funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string saludo = Saludo("Pedro","Lopez");
        }

        //se le pasan paremetros y devuelve un valor
        public static string Saludo(string nombre, string apellidos)
        {
            return "Mi nombre es: " + nombre + " " + apellidos;
        }

        //Que solo ejecutan codigo
        public static void Metodo()
        {
            Console.WriteLine("valor");
        }

        //Devuelve valor pero no recibe valores
        public static int FuncionSinParametros()
        {
            return 7 + 9;
        }

        //metodo, que no devuelve valor y recibe parametros
        public static void MetodoConParametros(string nombre,string apellido)
        {
            Console.WriteLine(nombre + " " + apellido);
        }

        
    }
}
