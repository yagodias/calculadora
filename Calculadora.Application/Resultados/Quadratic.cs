namespace Calculadora.Application.Resultados
{
    public class Quadratic
    {
        public Quadratic(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Delta { get => Math.Pow(B, 2) - 4 * A * C; }

        public double X1 { get => (-B + Math.Sqrt(Delta)) / (2 * A); }
        public double X2 { get => (-B - Math.Sqrt(Delta)) / (2 * A); }

        private double A { get; }
        private double B { get; }
        private double C { get; }
    }
}