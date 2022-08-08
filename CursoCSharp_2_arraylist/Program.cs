using System;
using System.Collections;

namespace CursoCSharp_2_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            ArrayList lista = new ArrayList();

            lista.Add(1);
            lista.Add("Batman");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            var elemento = lista[0];
            var elemento1 = lista[1];

            Console.WriteLine(elemento1);
            Console.ReadLine();

            int contador = lista.Count;

            lista.Insert(1, "Superman");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            lista.RemoveAt(1);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
