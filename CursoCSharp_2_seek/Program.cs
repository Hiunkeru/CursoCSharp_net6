using System;
using System.IO;

namespace CursoCSharp_2_seek
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream(150);
            var capacidad = ms.Capacity;
            var longitud = ms.Length;
            var posicion = ms.Position;

            ms.Seek(0, SeekOrigin.Begin);
            ms.Seek(10, SeekOrigin.Begin);
            ms.Seek(-10, SeekOrigin.Begin);

            ms.Seek(5, SeekOrigin.Current);
            ms.Seek(-10, SeekOrigin.Current);

        }
    }
}
