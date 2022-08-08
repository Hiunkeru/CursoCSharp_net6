using System;

namespace CursoCSharp_5_ejemplo_funciones
{
    class Program
    {
        //Ejemplo de reutilización de código
        static void Main(string[] args)
        {
            var opcion = PintaMenu();

            while (opcion != "5")
            {
                EjecutarOpcion(opcion);
                opcion = PintaMenu();
            }
            
        }

        public static string PintaMenu()
        {
            Console.WriteLine("**** Menu *****");
            Console.WriteLine("**** 1. Suma *****");
            Console.WriteLine("**** 2. Resta *****");
            Console.WriteLine("**** 3. Multiplicación *****");
            Console.WriteLine("**** 4. Mi Operación *****");
            Console.WriteLine("**** 5. Salir *****");
            return Console.ReadLine();
        }

        public static void EjecutarOpcion(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    Console.WriteLine(Suma(1, 7));
                    break;
                case "2":
                    Console.WriteLine(Resta(15, 9));
                    break;
                case "3":
                    Console.WriteLine(Multiplicacion(10, 3));
                    break;
                case "4":
                    Console.WriteLine(MiOperacion(5, 2));
                    break;
                default:
                    break;
            }
        }

        public static int Suma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static int Resta(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public static int Multiplicacion(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public static int MiOperacion(int numero1, int numero2)
        {
            var numeroSuma = Suma(numero1, numero2);
            var resta = Resta(numeroSuma, numero2);
            var multiplicacion = Multiplicacion(numeroSuma, resta);

            return resta;
        }
    }
}
