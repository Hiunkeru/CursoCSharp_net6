using System;
using System.Threading.Tasks;

namespace CursoCSharp_4_programacion_asinrona_4
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
            Task<Huevos> eggsTask = FreirHuevos(2);
            Task<Bacon> baconTask = FreirBacon(3);

            var toastTask = HacerTostadasConMantequillaYJamon(2);

            Zumo oj = HacerZumo();
            Console.WriteLine("zumo en su punto");

            Huevos eggs = await eggsTask;
            Console.WriteLine("huevos listos");

            Bacon bacon = await baconTask;
            Console.WriteLine("bacon listo");

            Tostada tostada = await toastTask;

            Console.WriteLine("desayuno preparado!");
        }


        async static Task<Tostada> HacerTostadasConMantequillaYJamon(int number)
        {
            var plainToast = await TostarPan(number);
            AplicarMantequilla(plainToast);
            AplicarJamon(plainToast);
            return plainToast;
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
