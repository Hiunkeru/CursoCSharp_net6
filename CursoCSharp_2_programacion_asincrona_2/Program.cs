using System;
using System.Threading.Tasks;

namespace CursoCSharp_2_programacion_asincrona_2
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
        static async Task Main(string[] args)
        {
            Cafe cup = HacerCafe();
            Console.WriteLine("cafe listo");
            Huevos eggs = await FreirHuevos(2);
            Console.WriteLine("huevos listos");
            Bacon bacon = await FreirBacon(3);
            Console.WriteLine("bacon listo");
            Tostada toast = await TostarPan(2);
            await AplicarMantequilla(toast);
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

        public static async Task<Huevos> FreirHuevos(int numHuevos)
        {
            return new Huevos();
        }

        public static async Task<Bacon> FreirBacon(int numHuevos)
        {
            return new Bacon();
        }

        public static async Task<Tostada> TostarPan(int numHuevos)
        {
            return new Tostada();
        }

        public static async Task AplicarMantequilla(Tostada tostada)
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
