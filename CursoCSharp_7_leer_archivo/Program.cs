using System;
using System.IO;
using System.Text;

namespace CursoCSharp_7_leer_archivo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fsEscribir = new FileStream("miArchivo.txt", FileMode.Create);

            string cadena = " Esto es una cadena de ejemplo";

            fsEscribir.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
            fsEscribir.Close();


            byte[] infoArchivo = new byte[100];

            FileStream fs = new FileStream("miArchivo.txt", FileMode.Open);
            fs.Read(infoArchivo, 0, (int)fs.Length);

            Console.WriteLine(ASCIIEncoding.ASCII.GetString(infoArchivo));
            Console.ReadKey();

            fs.Close();
        }
    }
}
