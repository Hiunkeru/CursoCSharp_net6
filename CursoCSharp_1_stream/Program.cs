using System;
using System.IO;

namespace CursoCSharp_1_memorystream
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream(150);
            var capacidad = ms.Capacity;
            var longitud = ms.Length;
            var posicion = ms.Position;

        }
    }
}
