using Calculadora.Application.Calculos;
using Calculadora.Application.Interfaces;
using Calculadora.Shared.Helpers;

namespace calculadora
{
    internal class Menu
    {
        public ICalculo Display()
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 = Calculadora");
            Console.WriteLine("2 = Equações");

            int option = InputHelper.GetConsoleInput<int>();
            ICalculo op;

            switch (option)
            {
                case 1: op = new CalculadoraSimples();
                    break;

                case 2: op = new Equacao();
                    break;

                default: throw new Exception("Opção inválida");
            }
            return op;
        }
    }
}
