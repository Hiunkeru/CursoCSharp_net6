using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp_3_diferencias_interfaces_clasesAbstractas
{
    public abstract class Vehiculos2
    {
        public void Mover()
        {
            Console.WriteLine("Moviendo {0} ruedas", Ruedas);
        }

        public abstract int Ruedas { get; }
    }

    public interface IVehiculos2
    {
        int Puertas { get; }
        bool EsAereo { get; }
    }

    public class Coche2 : Vehiculos , IVehiculos2
    {
        public override int Ruedas
        {
            get { return 4; }
        }

        public int Puertas => 4;

        public bool EsAereo => false;
    }

    public class Avion : Vehiculos, IVehiculos2
    {
        public override int Ruedas
        {
            get { return 2; }
        }

        public int Puertas => 3;

        public bool EsAereo => true;
    }

    public class Bicicleta2 : Vehiculos , IVehiculos2
    {
        public override int Ruedas
        {
            get { return 2; }
        }

        public int Puertas => 0;

        public bool EsAereo => false;
    }

}
