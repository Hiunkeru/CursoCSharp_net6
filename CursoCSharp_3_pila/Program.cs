using System;
using System.Collections;

namespace CursoCSharp_3_pila
{
    class Program
    {
        static void Main(string[] args)
        {
            //LIFO last in first out   -->primero que entra, ultimo que sale
            Stack pila = new Stack();

            pila.Push(1);
            pila.Push(5);
            pila.Push(10);
            pila.Push(3);

            //3 --> 10 --> 5 --> 1

            var numero = pila.Pop();

            Console.WriteLine(numero);
            Console.ReadLine();

            foreach (var item in pila)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }

            //Contar elementos
            int contador = pila.Count;

            //Limpiar la pila
            pila.Clear();

            if (pila.Contains(10))
            {
                Console.WriteLine("Contiene un 10");
            }
        }
    }
}
