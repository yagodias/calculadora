namespace Calculadora.Shared.Helpers
{
    public class InputHelper
    {
        public static T? GetConsoleInput<T>(string inputText = "")
        {
            if (inputText != "")
            {
                Console.WriteLine(inputText);
            }

            var input = Console.ReadLine();

            return (T?)Convert.ChangeType(input, typeof(T));
        }
    }
}
