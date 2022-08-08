using System;
using System.IO;

namespace CursoCSharp_5_introduccion_archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modos
            //FileMode.Append
            //FileMode.Create
            //FileMode.CreateNew
            //FileMode.Open
            //FileMode.OpenOrCreate
            //FileMode.Truncate

            FileStream fs = new FileStream("miArchivo.txt", FileMode.Create);

        }
    }
}
