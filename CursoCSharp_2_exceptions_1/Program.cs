using System;

namespace CursoCSharp_2_exceptions_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //bloque de código
                //object obj = "aa";
                //int variable = (int)obj;

                var numero = Ejemplo();
            }
            catch (OutOfMemoryException ex)
            {
                //capturamos la exception
            }
            catch (DivideByZeroException ex)
            {
                //capturamos la exception
            }
            catch (InvalidCastException ex)
            {
                //capturamos la exception
            }
            catch (Exception ex)
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
                throw ex;

                //return 0;
                //capturamos la exception
            }
            finally
            {
                //siempre se ejecuta
            }

            return 1;

        }

    }
}
