using CursoCSharp_3_exceptions_2.MyExceptions;
using System;

namespace CursoCSharp_3_exceptions_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //bloque de código
                int variable = Ejemplo();
            }
            catch (MyException ex)
            {
                //capturamos la exception
            }
            finally
            {
                //siempre se ejecuta
            }
        }

        public static int Ejemplo()
        {
            try
            {
                //bloque de código
                object obj = "aa";
                int variable = (int)obj;
            }
            catch (Exception ex)
            {
                throw new MyException();
            }

            return 1;

        }
    }
}
