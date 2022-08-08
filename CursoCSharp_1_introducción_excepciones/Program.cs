using System;

namespace CursoCSharp_1_introducción_excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //bloque de código
                object obj = "aa";
                int variable = (int)obj;
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
    }
}
