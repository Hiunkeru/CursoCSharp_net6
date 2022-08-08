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
        public string Apellidos { get; set; }
        public int Edad { get; private set; }
        public int Estado = 1;

        public readonly string Identificador = "XX";

        //Constructor
        public Clase()
        {
            Identificador = "ABCD";
            Edad = 10;
        }

        public void Metodo(int edad)
        {
            if(edad > 18)
            {
                Edad = edad;
            }
            
            //Identificador = "XXX";
        }
    }
}
