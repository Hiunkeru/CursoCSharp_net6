using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_14_destructores
{
    public class Punto
    {

        public int X { get; set; }
        public int Y { get; set; }

        public Punto()
        {
            X = 0;
            Y = 0;
        }

        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Punto(int x)
        {
            X = x;
            Y = 0;
        }

        //virguilla alt+126
        ~Punto()
        {
            X = 0;
            Y = 0;
        }

    }
}
