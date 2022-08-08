using System;

namespace CursoCSharp_1_delegados
{
    //Declaración de delegados
    public delegate void Del(string message);

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the delegate.
            Del handler = DelegateMethod;

            // Call the delegate.
            handler("Hello World");

            //DelegateMethod("Hello World");

            MethodWithCallback(1, 2, handler);

            MethodClass obj = new MethodClass();
            Del d1 = obj.Method1;
            Del d2 = obj.Method2;
            Del d3 = DelegateMethod;

            //Both types of assignment are valid.
            Del allMethodsDelegate = d1 + d2;
            allMethodsDelegate += d3;

            allMethodsDelegate("Llamando a delegados");

            //remove Method1
            allMethodsDelegate -= d1;

            allMethodsDelegate("Llamando a delegados");

            // copy AllMethodsDelegate while removing d2
            Del oneMethodDelegate = allMethodsDelegate - d2;
        }


        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }

    }

    public class MethodClass
    {
        public void Method1(string message) {
            Console.WriteLine(message);
        }
        public void Method2(string message) {
            Console.WriteLine(message);
        }
    }
}
