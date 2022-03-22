using Calculadora.Application.Interfaces;
using Calculadora.Application.Resultados;
using Calculadora.Shared.Helpers;
using MathNet.Numerics.LinearAlgebra;

namespace Calculadora.Application.Calculos
{
    public class CalcMatriz : ICalculo<MatrixResult>
    {
        public Matrix<double> Create()
        {
            var mSize = InputHelper.GetConsoleInput<int>("Qual a ordem da matriz??");

            var isRandom = InputHelper.GetConsoleInput<char>("Criar com dados aleatórios? S/N").ToString().ToLower() != "n";

            double[] nums = new double[mSize * mSize];

            var random = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = isRandom ?
                    random.Next(0, 100) :
                    InputHelper.GetConsoleInput<double>($"Digite o valor para a posição[{i}]");
            }

            return CreateMatrix.Dense(mSize, mSize, nums);
        }

        public MatrixResult Execute()
        {
            var matrix = Create();

            var result = new MatrixResult(matrix);

            Display(matrix);

            Console.WriteLine("\nInversa:");

            Display(result.Inverse);

            return result;
        }

        private void Display(Matrix<double> matrix)
        {
            Console.WriteLine("\nMatriz:");

            for (int row = 0; row < matrix.RowCount; row++)
            {
                for (int column = 0; column < matrix.ColumnCount; column++)
                    Console.Write("\t" + matrix[row, column]);
                Console.Write("\n");
            }
        }
    }
}