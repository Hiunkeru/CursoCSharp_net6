using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp_5_programacion_asincrona_5_2
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

        static async Task Main2(string[] args)
        {
            Cafe cup = HacerCafe();
            Console.WriteLine("coffee is ready");
            var eggsTask = FreirHuevos(2);
            var baconTask = FreirBacon(3);
            var toastTask = HacerTostadasConMantequillaYJamon(2);

            var allTasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (allTasks.Any())
            {
                Task finished = await Task.WhenAny(allTasks);
                if (finished == eggsTask)
                {
                    Console.WriteLine("eggs are ready");
                    allTasks.Remove(eggsTask);
                    var eggs = await eggsTask;
                }
                else if (finished == baconTask)
                {
                    Console.WriteLine("bacon is ready");
                    allTasks.Remove(baconTask);
                    var bacon = await baconTask;
                }
                else if (finished == toastTask)
                {
                    Console.WriteLine("toast is ready");
                    allTasks.Remove(toastTask);
                    var toast = await toastTask;
                }
                else
                    allTasks.Remove(finished);
            }
            Console.WriteLine("Breakfast is ready!");

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
