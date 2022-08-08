using System;

namespace CursoCSharp_3_metodos_anonimos
{
    delegate void Printer(string s);

    class Program
    {
        static void Main()
        {

            Printer printer = DoWork;
            Printer printer2 = delegate (string k) { Console.WriteLine(k); };


            // Instantiate the delegate type using an anonymous method.
            Printer p = delegate (string j)
            {
                Console.WriteLine(j);
            };

            // Results from the anonymous delegate call.
            p("The delegate using the anonymous method is called.");

            // The delegate instantiation using a named method "DoWork".
            p = DoWork;

            // Results from the old style delegate call.
            p("The delegate using the named method is called.");
        }

        static void DoWork(string k)
        {
            Console.WriteLine(k);
        }
    }
}
