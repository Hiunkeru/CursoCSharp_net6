using System;

namespace CursoCSharp_2_eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Event e = new Event();
            //Se crea el evento y asigna el metodo estatico al evento, 
            e.evento += OnEvent;
            //hace lo mismo que la primera pero con el EventHandler, ambas funcionan igual
            e.evento += new Event.EventHandler(OnEvent);
            e.evento -= new Event.EventHandler(OnEvent);

            e.OnEvento("Se lanza Evento");
        }

        public static void OnEvent(string s)
        {
            Console.WriteLine(s);
        }

        public class Event
        {
            public delegate void EventHandler(string s);

            public event EventHandler evento;

            public void OnEvento(string s)
            {
                if (evento != null)
                    evento(s);
            }
        }
    }
}
