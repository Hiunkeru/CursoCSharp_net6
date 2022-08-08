using System;
using System.Threading.Tasks;

namespace CursoCSharp_5_programacion_asincrona_5
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

            await Task.WhenAll(eggsTask, baconTask, toastTask);
            Console.WriteLine("huevos listos");
            Console.WriteLine("bacon listo");
            Console.WriteLine("tostadas preparadas");
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
