internal class Program
{
    private const string ADD = "add";
    private const string DIV = "div";
    private const string MUL = "mul";
    private const string SUB = "sub";

    private static float Calculate(float[] parameters, string operation)
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

    private static T? GetConsoleInput<T>(string inputText)
    {
        Console.WriteLine(inputText);

        var input = Console.ReadLine();

        return (T?)Convert.ChangeType(input, typeof(T));
    }

    private static void Main()
    {
        var firstNum = GetConsoleInput<int>("First number??");
        var operation = GetConsoleInput<string>("Wich operation??");
        var secondNum = GetConsoleInput<int>("Second number??");

        var parameters = new float[] { firstNum, secondNum };

        var result = Calculate(parameters, operation!);

        Console.WriteLine("Result: {0}", result);
    }
}