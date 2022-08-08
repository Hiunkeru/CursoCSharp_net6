using System;

namespace CursoCSharp_1_programacion_asincrona_1
{

    public class Cafe
    {

    }

    public class Huevos
    {

    }

    public class Bacon
    {

    }

    public class Tostada
    {

    }

    public class Zumo
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
            Cafe cup = HacerCafe();
            Console.WriteLine("cafe listo");
            Huevos eggs = FreirHuevos(2);
            Console.WriteLine("huevos listos");
            Bacon bacon = FreirBacon(3);
            Console.WriteLine("bacon listo");
            Tostada toast = TostarPan(2);
            AplicarMantequilla(toast);
            AplicarJamon(toast);
            Console.WriteLine("tostadas preparadas");
            Zumo oj = HacerZumo();
            Console.WriteLine("zumo en su punto");

            Console.WriteLine("desayuno preparado!");
        }

        public static Cafe HacerCafe()
        {
            return new Cafe();
        }

        public static Huevos FreirHuevos(int numHuevos)
        {
            return new Huevos();
        }

        public static Bacon FreirBacon(int numHuevos)
        {
            return new Bacon();
        }

        public static Tostada TostarPan(int numHuevos)
        {
            return new Tostada();
        }

        public static void AplicarMantequilla(Tostada tostada)
        {
           
        }

        public static void AplicarJamon(Tostada tostada)
        {
            
        }

        public static Zumo HacerZumo()
        {
            return new Zumo();
        }

    }
}
