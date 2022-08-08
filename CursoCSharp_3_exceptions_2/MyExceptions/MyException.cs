using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_3_exceptions_2.MyExceptions
{
    public class MyException : ApplicationException
    {

        public MyException() : base("Esta es mi custom exception")
        {

        }

    }
}
