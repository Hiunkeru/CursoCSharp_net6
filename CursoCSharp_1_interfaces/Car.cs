using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_1_interfaces
{
    public class Car : Program ,IEquatable<Car>, IComparacion
    {
        public bool Equals(Car obj)
        {
            throw new NotImplementedException();
        }

        public int EsIgual(int numero)
        {
            throw new NotImplementedException();
        }

        public int EsIgualaCoche(int numero)
        {
            throw new NotImplementedException();
        }
    }
}
