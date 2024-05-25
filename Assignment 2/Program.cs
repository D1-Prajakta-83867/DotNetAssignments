using System;

class Calculator
{
    static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Usage: Calculator <number1> <operation> <number2>");
            return;
        }

        double num1, num2, result;
        if (!double.TryParse(args[0], out num1) || !double.TryParse(args[2], out num2))
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
            return;
        }

        char operation = args[1][0];

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Error: Division by zero!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid operation! Please use '+', '-', '*', or '/'.");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }
}
