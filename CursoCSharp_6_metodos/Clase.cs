using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_5_campos_propiedades
{
    public class Clase
    {
        //Campos o Propiedades
        public int Campo;
        public string Nombre { get; set; }
        public readonly string Identificador = "XX";

        //Constructor
        public Clase()
        {

        }

        //Metodo
        public void Calcular(int edad)
        {
            //Operacion de nuestro metodo
            Console.WriteLine(edad + 15);
        }

        //Metodo
        public int Sumar(int numero , int numero2)
        {
            //Operacion de nuestro metodo
            return numero + numero2;
        }
    }
}
