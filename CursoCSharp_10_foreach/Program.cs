using System;
using System.Collections.Generic;
using static System.Console;

namespace CursoCSharp_10_foreach
{
    class Program
    {
        static void Main(string[] args)
        {

            var listaDeNumero = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (var numero in listaDeNumero)
            {
                WriteLine(numero);
            }


            var listaDePersonas = new List<Persona>();

            var persona1 = new Persona()
            {
                Apellido = "Sanchez",
                Edad = 22,
                Nombre = "Pedro"
            };

            var persona2 = new Persona()
            {
                Apellido = "Gomez",
                Edad = 28,
                Nombre = "Alejandro"
            };

            listaDePersonas.Add(persona1);
            listaDePersonas.Add(persona2);

            foreach (var persona in listaDePersonas)
            {
                WriteLine(persona.Nombre + " " + persona.Apellido + " " + " tiene " + persona.Edad + " años");
            }

        }
    }


    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
    }

}
