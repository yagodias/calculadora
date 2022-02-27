using calculadora;

internal class Program
{
    private static void Main()
    {
        var menu = new Menu();

        var op = menu.Display();

        op.Execute();
    }
}