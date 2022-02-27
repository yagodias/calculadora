using calculadora;

internal class Program
{
    private static void Main()
    {
        var operation = new Menu()
            .GetOperation();

        operation.Execute();
    }
}