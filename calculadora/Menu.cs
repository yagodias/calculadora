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
            Console.WriteLine("3 = Matriz Inversa");

            var option = InputHelper.GetConsoleInput<int>();

            switch (option)
            {
                case 1:
                    ICalculo<CalculadoraSimplesResult> op1 = new CalculadoraSimples();
                    op1.Execute();
                    break;

                case 2:
                    ICalculo<QuadraticResult> op2 = new Equacao();
                    op2.Execute();
                    break;

                case 3:
                    ICalculo<MatrixResult> op3 = new CalcMatriz();
                    op3.Execute();
                    break;

                default: throw new ArgumentException("Opção inválida");
            }
        }
    }
}
