using System;

namespace CursoCSharp_1_clases_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CuentaBancaria cuenta1 = new CuentaBancaria();

            cuenta1.Saldo = 1500;

            CuentaBancaria cuenta2 = new CuentaBancaria();
            cuenta2.Saldo = 2200;

            int suma = cuenta1.Saldo + cuenta2.Saldo;

        }
    }
}
