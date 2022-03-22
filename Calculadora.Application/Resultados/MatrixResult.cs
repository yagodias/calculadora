using MathNet.Numerics.LinearAlgebra;

namespace Calculadora.Application.Resultados
{
    public class MatrixResult : BaseResult
    {
        private readonly Matrix<double> matrix;

        public MatrixResult(Matrix<double> matrix)
        {
            this.matrix = matrix;
        }

        public Matrix<double> Inverse { get => matrix.Inverse(); }
    }
}