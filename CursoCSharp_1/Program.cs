using System;

namespace CursoCSharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 a 255
            byte v1 = 200;
            Console.WriteLine("Valor almacenado en la variable de tipo byte:" + v1);

            //-128 a 127
            sbyte v2 = -100;
            Console.WriteLine("Valor almacenado en la variable de tipo sbyte:" + v2);

            //-32768 a 32767
            short v3 = 30000;
            Console.WriteLine("Valor almacenado en la variable de tipo short:" + v3);

            //0 a 65535
            ushort v4 = 60000;
            Console.WriteLine("Valor almacenado en la variable de tipo ushort:" + v4);

            //–2147483648 a 2147483647
            int v5 = -2000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo int:" + v5);

            //0 a 4294967295
            uint v6 = 2000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo uint:" + v6);

            //–9223372036854775808 a 9223372036854775807
            long v7 = -1000000000000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo long:" + v7);

            //0, 18446744073709551615
            ulong v8 = 1000000000000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo ulong:" + v8);
            Console.ReadKey();

            Console.WriteLine("Bytes reservados para el tipo byte:" + sizeof(byte));
            Console.WriteLine("Bytes reservados para el tipo sbyte:" + sizeof(sbyte));
            Console.WriteLine("Bytes reservados para el tipo short:" + sizeof(short));
            Console.WriteLine("Bytes reservados para el tipo ushort:" + sizeof(ushort));
            Console.WriteLine("Bytes reservados para el tipo int:" + sizeof(int));
            Console.WriteLine("Bytes reservados para el tipo uint:" + sizeof(uint));
            Console.WriteLine("Bytes reservados para el tipo long:" + sizeof(long));
            Console.WriteLine("Bytes reservados para el tipo ulong:" + sizeof(ulong));
            Console.WriteLine("Bytes reservados para el tipo float:" + sizeof(float));
            Console.WriteLine("Bytes reservados para el tipo double:" + sizeof(double));
            Console.WriteLine("Bytes reservados para el tipo decimal:" + sizeof(decimal));
            Console.WriteLine("Bytes reservados para el tipo char:" + sizeof(char));
            Console.WriteLine("Bytes reservados para el tipo bool:" + sizeof(bool));
            Console.ReadKey();

            Console.WriteLine("Valor mínimo y máximo para tipo de dato float.");
            Console.WriteLine("Mínimo:" + float.MinValue);
            Console.WriteLine("Máximo:" + float.MaxValue);
            Console.WriteLine("Valor mínimo y máximo para tipo de dato double.");
            Console.WriteLine("Mínimo:" + double.MinValue);
            Console.WriteLine("Máximo:" + double.MaxValue);
            Console.WriteLine("Valor mínimo y máximo para tipo de dato decimal.");
            Console.WriteLine("Mínimo:" + decimal.MinValue);
            Console.WriteLine("Máximo:" + decimal.MaxValue);
            Console.ReadKey();

            char caracter = 'a';
            Console.WriteLine("Caracter:" + caracter);

            string cadena = "Cadena";
            Console.WriteLine("Cadena:" + cadena);

            bool boleano = false;
            Console.WriteLine("Esto es : " + boleano);

            

            dynamic dinamico = 12;
            Console.WriteLine("Este tipo es dinamico:" + dinamico);

            object objeto = 15;
            Console.WriteLine("Este tipo es un objeto:" + objeto);

        }
    }
}
