namespace DemoLibrary
{
    public class Calculadora
    {
        public static decimal sumar(decimal n1, decimal n2)
        {
            return n1 + n2;
        }

        public static decimal restar(decimal n1, decimal n2) => n1 - n2;

        public Func<decimal, decimal, decimal> multipliacion = (v1, v2) => v1 * v2;

        public static decimal dividir(decimal n1, decimal n2)
        {
            return n1 / n2;
        }
    }
}