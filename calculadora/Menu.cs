using Calculadora.Application.Calculos;
using Calculadora.Application.Interfaces;
using Calculadora.Shared.Helpers;

namespace calculadora
{
    internal class Menu
    {
        public ICalculo GetOperation()
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 = Calculadora");
            Console.WriteLine("2 = Equações");

            int option = InputHelper.GetConsoleInput<int>();

            ICalculo op = option switch
            {
                1 => new CalculadoraSimples(),
                2 => new Equacao(),
                _ => throw new Exception("Opção inválida"),
            };

            return op;
        }
    }
}
