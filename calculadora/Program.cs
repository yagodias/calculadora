
class calc
{
    static void Main()
    {
        Console.WriteLine("First number??");
        var firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Wich operation??");
        var operation = Console.ReadLine();

        Console.WriteLine("Second number");
        int secondNum = int.Parse(Console.ReadLine());

        switch (operation)
        {
            case "plus":
                Console.WriteLine(firstNum + secondNum);
                break;
            case "less":
                Console.WriteLine(firstNum - secondNum);
                break;
            case "multi":
                Console.WriteLine(firstNum * secondNum);
                break;
            case "div":
                Console.WriteLine(firstNum / secondNum);
                break;
        }
    }
}
