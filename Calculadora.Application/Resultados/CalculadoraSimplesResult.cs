namespace Calculadora.Application.Resultados
{
    public class CalculadoraSimplesResult : BaseResult
    {
        public double Resultado { get; private set; }

        public CalculadoraSimplesResult(double resultado)
        {
            Resultado = resultado;
        }
    }
}
