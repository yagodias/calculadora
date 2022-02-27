﻿using Calculadora.Application.Interfaces;
using Calculadora.Application.Resultados;
using Calculadora.Shared.Helpers;

namespace Calculadora.Application.Calculos
{
    public class Equacao : ICalculo
    {
        public void Execute()
        {
            var a = InputHelper.GetConsoleInput<double>("Digite A: ");
            var b = InputHelper.GetConsoleInput<double>("Digite B: ");
            var c = InputHelper.GetConsoleInput<double>("Digite C: ");

            var result = new Quadratic(a, b, c);

            Console.WriteLine("Resultado:\n\tx1 {0}\n\tx2 {1}", result.X1, result.X2);

            //return result;
        }
    }
}