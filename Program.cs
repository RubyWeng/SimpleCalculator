namespace SimpleCalculator;

class Program
{
    static void Main(string[] args)
    {
        double num1, num2, result;
        string operation;

        Console.WriteLine("Welcome to Calculation!");
        Console.WriteLine("Please input 2 num and 1 operation");

        Console.WriteLine("The first number :");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid!");
        }

        Console.WriteLine("The operation is :");
        operation = Console.ReadLine();

        Console.WriteLine("The second number :");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid!");
        }

        switch (operation)
        {

            case "+":
                result = num1 + num2;
                Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + result);
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + result);
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + result);
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.Write("Divisor Can't set 0 !");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + result);
                }

                break;
            default:
                Console.WriteLine("Invalid!");
                break;
        }

    }
}
