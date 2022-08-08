using System;
using static System.Console;
using static System.Math;
using AliasToMyClass = OtroNamespace.Ejemplo.Namespace.MyClass;


namespace CursoCSharp_7_instrucion_using
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(Sqrt(3 * 3 + 4 * 4));

            AliasToMyClass instance1 = new AliasToMyClass();
            Console.WriteLine(instance1);

        }
    }
}
