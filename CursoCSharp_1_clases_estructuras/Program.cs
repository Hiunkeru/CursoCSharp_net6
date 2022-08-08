using System;

namespace CursoCSharp_1_clases_estructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Point punto = new Point();
            punto.X = 10;
            punto.Y = 8;


            PointStruct puntoStruct = new PointStruct();
            puntoStruct.X = 20;
            puntoStruct.Y = 7;

            SumaCoordenadas(punto);
            SumarCoordenadas(puntoStruct);

            Console.WriteLine($"Suma de coordenadas clase: X={punto.X} Y={punto.Y}");
            Console.WriteLine($"Suma de coordenadas struct: X={puntoStruct.X} Y={puntoStruct.Y}");
            Console.ReadKey();
        }

        public static void SumaCoordenadas(Point point)
        {
            point.X = point.X + 10;
            point.Y = point.Y + 10;
        }

        public static void SumarCoordenadas(PointStruct pointStruct)
        {
            pointStruct.X = pointStruct.X + 10;
            pointStruct.Y = pointStruct.Y + 10;
        }

    }
}
