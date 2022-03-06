using Calculadora.Application.Interfaces;
using Calculadora.Application.Resultados;
using Calculadora.Shared.Helpers;

namespace Calculadora.Application.Calculos
{
    public class Equacao : ICalculo <QuadraticResult>
    {
        public QuadraticResult Execute()
        {
            var a = InputHelper.GetConsoleInput<double>("Digite A: ");
            var b = InputHelper.GetConsoleInput<double>("Digite B: ");
            var c = InputHelper.GetConsoleInput<double>("Digite C: ");

            var result = Calcular(a, b, c);

            Console.WriteLine("Resultado:\n\tx1 {0}\n\tx2 {1}", result.X1, result.X2);

            return result;
        }

        public QuadraticResult Calcular(double a, double b, double c)
        {
            return new QuadraticResult(a, b, c);
        }
    }
}