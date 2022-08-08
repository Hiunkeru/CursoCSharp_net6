using System;
using System.IO;

namespace CursoCSharp_3_leer_datos_stream
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream(150);
            var capacidad = ms.Capacity;
            var longitud = ms.Length;
            var posicion = ms.Position;

            byte[] buffer = new byte[50];

            ms.Read(buffer, 0, 5);

        }
    }
}
