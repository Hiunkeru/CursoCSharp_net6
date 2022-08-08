using System;

namespace CursoCSharp_4_encapsulacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.X = 5000;

            try
            {
                PointEncapsulado pointEnc = new PointEncapsulado();
                //pointEnc.SetX(80);
                //pointEnc.SetY(90);

                //pointEnc.X = 56;
                pointEnc.SetXPrivate(56);
                
                Console.WriteLine(pointEnc.GetX());
                Console.WriteLine(pointEnc.GetY());

                Console.WriteLine(pointEnc.X);
            }
            catch(Exception ex)
            {
                Console.Write("exception");
            }
            
        }
    }
}
