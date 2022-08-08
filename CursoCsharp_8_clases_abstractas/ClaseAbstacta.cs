using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp_8_clases_abstractas
{
    public abstract class ClaseAbstacta
    {
        public abstract int Sumar(int i, int z);

        public virtual int Restar(int i, int z)
        {
            return i - z;
        }
    }
}
