using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsolaAvanzado
{
    public interface IVehiculo {
        void Acelerar(int kmh);
        void Frenar();
        void Girar(int angulo);
    }

    public class Carro : IVehiculo
    {
        public void Acelerar(int kmh)
        {
            Console.WriteLine("Acelerando a " + kmh);
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando");
        }

        public void Girar(int angulo)
        {
            Console.WriteLine("Girando " + angulo);
        }
    }
}
