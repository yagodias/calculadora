using Calculadora.Application.Interfaces;
using Calculadora.Shared.Helpers;

namespace Calculadora.Application.Calculos
{
    public class Equacao : ICalculo
    {
        public void Execute()
        {
            var a = InputHelper.GetConsoleInput<double>("Digite A: ");
            var b = InputHelper.GetConsoleInput<double>("Digite B: ");
            var c = InputHelper.GetConsoleInput<double>("Digite C: ");

            (double X1, double X2) = CalcularResultado(a, b, c);
            
            Console.WriteLine("Resultado do X1 = " + X1);
            Console.WriteLine("Resultado do X2 = " + X2);

        }

        public double CalcularDelta(double A, double B, double C)
        {
            var _delta = Math.Pow(B, 2) - 4 * A * C;

            return _delta;
        }

        public (double X1, double X2) CalcularResultado(double A, double B, double C)
        {
            var _delta = CalcularDelta(A, B, C);
            var raizDelta = Math.Sqrt(_delta);

            var X1 = (-B + raizDelta) / (2 * A);
            var X2 = (-B - raizDelta) / (2 * A);

            return (X1, X2);
        }
    }
}
