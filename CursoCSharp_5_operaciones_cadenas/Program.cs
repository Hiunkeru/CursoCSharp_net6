using System;

namespace CursoCSharp_5_operaciones_cadenas
{
    class Program
    {
        static void Main(string[] args)
        {

            string villano = "Gru";
            string esbirros = "Minions";
            string frase = "Los minions ayudan a Gru a conquistar el mundo";

            //Concatenar cadenas
            string concatenar = String.Concat(villano, " tiene ", esbirros);
            Console.WriteLine(concatenar);
            Console.ReadLine();

            //Encontrar cadena
            if (villano.Contains("Gru"))
            {
                //codigo
            }

            if (esbirros.Contains("Mini"))
            {
                //codigo
            }

            //Obtener subcadena
            string subcadena = frase.Substring(4, 7);
            Console.WriteLine(subcadena);
            Console.ReadLine();

            //Una cadena acaban en...
            if (frase.EndsWith("mundo"))
            {
                //codigo
            }

            //Insertar una cadena en otra

            frase =  frase.Insert(3, " adorables");
            Console.WriteLine(frase);
            Console.ReadLine();

            //encontrar posicion de una cadena
            var posicion = frase.LastIndexOf("mundo");
            frase = frase.Insert(posicion, "enorme ");

            Console.WriteLine(frase);
            Console.ReadLine();

            //borrar cadena
            var posicion2 = frase.LastIndexOf("enorme");
            frase = frase.Remove(posicion2, 7);

            Console.WriteLine(frase);
            Console.ReadLine();

            //Reemplazar cadena
            frase = frase.Replace("mundo", "luna");

            Console.WriteLine(frase);
            Console.ReadLine();

            //Dividir cadena
            var palabras = frase.Split(' ');

            foreach (var palabra in palabras)
            {
                Console.WriteLine(palabra);
            }

            Console.ReadLine();

            //Pasar mayusculas y minuculas
            string GRU = villano.ToUpper();
            string esbirros2 = esbirros.ToLower();
            Console.WriteLine(GRU);
            Console.WriteLine(esbirros2);

            Console.ReadLine();

            //Podar cadenas
            string espaciosDelanteros = "  palabra";
            string espaciosTraseros = "palabras   ";
            string espacios = "   palabras   ";

            Console.WriteLine(espaciosDelanteros.TrimStart());
            Console.WriteLine(espaciosTraseros.TrimEnd());
            Console.WriteLine(espacios.Trim());
        }
    }
}
