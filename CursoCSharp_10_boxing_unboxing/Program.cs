using System;

namespace CursoCSharp_10_boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;

            // Boxing copies the value of i into object o.
            object o = i;

            o = 456;
            i = (int)o;  // unboxing


            int i2 = 123;
            object o2 = i2;  // implicit boxing

            try
            {
                //int j = (short)o2;  // attempt to unbox
                int j = (int)o;

                System.Console.WriteLine("Unboxing OK.");
            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
            }


        }
    }
}
