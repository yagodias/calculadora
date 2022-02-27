using Calculadora.Application.Calculos;
using Calculadora.Application.Interfaces;
using Calculadora.Application.Resultados;
using Calculadora.Shared.Helpers;

namespace calculadora
{
    internal class Menu
    {
        public void Display()
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 = Calculadora");
            Console.WriteLine("2 = Equações");

            var option = InputHelper.GetConsoleInput<int>();
            
            ICalculo op = option switch
            {
                1 => new CalculadoraSimples(),
                2 => new Equacao(),
                _ => throw new Exception("Opção inválida"),
            };

            op.Execute();}
    }
}
