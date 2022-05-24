using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsolaAvanzado
{
    public abstract class Pieza {
        public abstract decimal Area();
        public abstract decimal Perimetro(); 
    }

    public class Cuadrado : Pieza
    {
        public readonly decimal Lado;
        public Cuadrado(decimal lado)
        {
            Lado = lado;
        }

        public override decimal Area() => Lado * Lado;

        public override decimal Perimetro() => Lado * 4;
    }
}
