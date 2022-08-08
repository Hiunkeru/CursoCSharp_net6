using System;

namespace CursoCSharp_2_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje = Console.ReadLine();
            string hola = null;

            int edad = default(int);  //0
            int? altura = null;
            bool verdadero = default(bool); //false

            edad = edad + 5;

            if(altura == null)
            {
                //hacer algo
            }

            DateTime? fecha = new DateTime();
            fecha = null;

            //comprobar nulo
            int? dia = fecha?.Day;

            Console.Write(edad);
            Console.ReadLine();

            var peso = 85;
        }
    }
}
