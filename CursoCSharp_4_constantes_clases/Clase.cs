using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_4_constantes_clases
{
    public class Clase
    {
        //Constantes
        const int IVA = 9;
        const int IVA7 = 7, IVA11 = 11, IVA21 = 21;

        private int Importe { get; set; }

        public int CalcularImporte(int importe)
        {
           
            //IVA = 11; //No se puede modificar
            return importe + (importe * IVA);
        }
    }
}
