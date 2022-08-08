using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_1_interfaces
{
    interface IEquatable<T>
    {
        bool Equals(T obj);
        int EsIgual(int numero);
    }

    interface IComparacion
    {       
        int EsIgualaCoche(int numero);
    }
}
