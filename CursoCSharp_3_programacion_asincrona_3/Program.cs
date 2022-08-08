using System;
using System.Threading.Tasks;

namespace CursoCSharp_3_programacion_asincrona_3
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
            //static async Task Main(string[] args)
            //{
            //    Cafe cup = HacerCafe();
            //    Console.WriteLine("cafe listo");
            //    Task<Huevos> eggsTask = FreirHuevos(2);
            //    Huevos eggs = await eggsTask;
            //    Console.WriteLine("huevos listos");

            //    Task<Bacon> baconTask = FreirBacon(3);
            //    Bacon bacon = await baconTask;
            //    Console.WriteLine("bacon listo");

            //    Task<Tostada> toastTask = TostarPan(2);
            //    Tostada toast = await toastTask;

            //    await AplicarMantequilla(toast);
            //    AplicarJamon(toast);
            //    Console.WriteLine("tostadas preparadas");
            //    Zumo oj = HacerZumo();
            //    Console.WriteLine("zumo en su punto");

            //    Console.WriteLine("desayuno preparado!");
            //}


        static async Task Main(string[] args)
        {
            Cafe cup = HacerCafe();
            Console.WriteLine("cafe listo");
            Task<Huevos> eggsTask = FreirHuevos(2);
            Task<Bacon> baconTask = FreirBacon(3);

            Task<Tostada> toastTask = TostarPan(2);
            Tostada toast = await toastTask;

            await AplicarMantequilla(toast);
            AplicarJamon(toast);
            Console.WriteLine("tostadas preparadas");
            Zumo oj = HacerZumo();
            Console.WriteLine("zumo en su punto");

            Huevos eggs = await eggsTask;
            Console.WriteLine("huevos listos");

            Bacon bacon = await baconTask;
            Console.WriteLine("bacon listo");

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

