using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_6_poliformismo
{
    public class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("El perro hace Guau Guau");
        }
    }
}
