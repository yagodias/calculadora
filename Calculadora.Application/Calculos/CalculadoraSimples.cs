using Calculadora.Application.Interfaces;
using Calculadora.Shared.Helpers;

namespace Calculadora.Application.Calculos
{
    public class CalculadoraSimples : ICalculo
    {
        private const string ADD = "add";

        private const string DIV = "div";

        private const string MUL = "mul";

        private const string SUB = "sub";

        public void Execute()
        {
            var firstNum = InputHelper.GetConsoleInput<int>("First number??");
            var operation = InputHelper.GetConsoleInput<string>("Wich operation??");
            var secondNum = InputHelper.GetConsoleInput<int>("Second number??");

            var parameters = new float[] { firstNum, secondNum };

            var result = Calculate(parameters, operation!);

            Console.WriteLine("Result: {0}", result);
        }

        private float Calculate(float[] parameters, string operation)
        {
            float result = parameters[0];

            switch (operation.ToLower())
            {
                case ADD:
                    for (int i = 1; i < parameters.Length; i++)
                        result += parameters[i];
                    break;

                case DIV:
                    for (int i = 1; i < parameters.Length; i++)
                        result /= parameters[i];
                    break;

                case MUL:
                    for (int i = 1; i < parameters.Length; i++)
                        result *= parameters[i];
                    break;

                case SUB:
                    for (int i = 1; i < parameters.Length; i++)
                        result -= parameters[i];
                    break;

                default:
                    return result;
            }

            return result;
        }
    }
}