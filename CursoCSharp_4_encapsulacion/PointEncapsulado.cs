using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_4_encapsulacion
{
    public class PointEncapsulado
    {
        public int X { get; private set; }
        public int Y { get; set; }

        //public void SetX(int value)
        //{
        //    if(value < 100)
        //        X = value;
        //    else
        //        throw new ArgumentOutOfRangeException();
        //}

        //public void SetY(int value)
        //{
        //    if (value > 50)
        //        Y = value;
        //    else
        //        throw new ArgumentOutOfRangeException();
        //}


        public void SetXPrivate(int value)
        {
            if (value < 100)
                X = value;
            else
                throw new ArgumentOutOfRangeException();
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }
    }
}
