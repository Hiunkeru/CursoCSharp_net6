using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp_8_clases_abstractas
{
    public class ClaseDerivada : Clase
    {
        public override int Restar(int i, int z)
        {
            return i + z;
        }
    }
}
