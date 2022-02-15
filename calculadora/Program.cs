internal class calc
{
    private static float Calculate(float[] parameters, string? operation)
    {
        float result = parameters[0];

        switch (operation)
        {
            case "add":
                for (int i = 1; i < parameters.Length; i++)
                    result += parameters[i];
                break;

            case "sub":
                for (int i = 1; i < parameters.Length; i++)
                    result -= parameters[i];
                break;

            case "mul":
                for (int i = 1; i < parameters.Length; i++)
                    result *= parameters[i];
                break;

            case "div":
                for (int i = 1; i < parameters.Length; i++)
                    result /= parameters[i];
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

        var result = Calculate(parameters, operation);

        Console.WriteLine("Result: {0}", result);
    }
}