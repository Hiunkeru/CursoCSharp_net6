using CursoCSharp_7_nivel_accesibilidad;
using System;

namespace CursoCSharp_6_nivel_accesibilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseDerivada clasedev = new ClaseDerivada();
            clasedev.Nacionalidad = "Española";
            clasedev.Nombre = "Alejandro";
            clasedev.Telefono = "1122233";
            clasedev.Sumar(6,7);
        }
    }
}
