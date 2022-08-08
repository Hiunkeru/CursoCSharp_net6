using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp_3_diferencias_interfaces_clasesAbstractas
{
    public abstract class Vehiculos
    {
        public void Mover()
        {
            Console.WriteLine("Moviendo {0} ruedas", Ruedas);
        }

        public abstract int Ruedas { get; }
    }

    public class Coche : Vehiculos
    {
        public override int Ruedas
        {
            get { return 4; }
        }
    }

    public class Bicicleta : Vehiculos
    {
        public override int Ruedas
        {
            get { return 2; }
        }
    }


    public interface IVehiculos
    {
        void Mover();
        int Ruedas { get; }
    }

    public class CocheI : IVehiculos
    {
        public int Ruedas
        {
            get { return 4; }
        }

        public void Mover()
        {
            throw new NotImplementedException();
        }
    }

    public class BicicletaI : IVehiculos
    {
        public int Ruedas
        {
            get { return 2; }
        }

        public void Mover()
        {
            throw new NotImplementedException();
        }
    }


}
