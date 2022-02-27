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

            (double x1, double x2) = CalcularResultado(a, b, c);

            Console.WriteLine("Resultado:\n\tx1 {0}\n\tx2 {1}", x1, x2);
        }

        private double CalcularDelta(double a, double b, double c)
        {
            var delta = Math.Pow(b, 2) - 4 * a * c;

            return delta;
        }

        private (double X1, double X2) CalcularResultado(double a, double b, double c)
        {
            var delta = CalcularDelta(a, b, c);
            var raizDelta = Math.Sqrt(delta);

            var x1 = (-b + raizDelta) / (2 * a);
            var x2 = (-b - raizDelta) / (2 * a);

            return (x1, x2);
        }
    }
}