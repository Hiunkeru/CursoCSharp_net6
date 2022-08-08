using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoCSharp_2_interfaz_IDisposable
{
    class UsingClass
    {
        public void UsingExample()
        {
            Char[] buffer = new Char[50];
            using (StreamReader s = new StreamReader("File1.txt"))
            {
                int charsRead = 0;
                while (s.Peek() != -1)
                {
                    charsRead = s.Read(buffer, 0, buffer.Length);
                    //
                    // Process characters read.
                    //   
                }
            }
        }
    }
}
