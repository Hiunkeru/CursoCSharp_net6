using System;

namespace CursoCSharp_5_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            //IF Else

            bool bandera = true;

            if (bandera)
            {
                //si bandera = true
            }
            else
            {
                //si bandera = false
            }

            int suma = 12 + 8;

            if(suma <= 30)
            {
                //Suma es menor o igual a 30
            }
            else
            {
                //Suma es mayor o igual a 30
            }

            if(suma.GetType() == typeof(int))
            {
                //Si suma es un entero
            }

            //Seguiria la ejecución


            var multiplicacion = 20;
            if(suma == 20 && bandera)
            {

                if(multiplicacion > 30)
                {

                }
                else
                {
                    if (bandera)
                    {

                    }
                }

            }

        }
    }
}
