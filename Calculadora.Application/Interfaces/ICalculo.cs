using Calculadora.Application.Resultados;

namespace Calculadora.Application.Interfaces
{
    public interface ICalculo <TResultado> where TResultado : BaseResult
    {
        TResultado Execute();
    }
}
