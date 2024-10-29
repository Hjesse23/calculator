do
{
    Console.WriteLine("---Welcome to the Calculator Program---");
    Console.WriteLine("Choose an operation:");

    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("5. Exit");

    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 5)
    {
        break;
    }

    Console.Write("Enter first number: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter second number: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    double result;

    switch (choice)
    {
        case 1:
            result = Addition(num1, num2);
            Console.WriteLine($"The result of {num1} + {num2} equals {result}");
            break;

        case 2:
            result = Subtraction(num1, num2);
            Console.WriteLine($"The result of {num1} - {num2} equals {result}");
            break;

        case 3:
            result = Multiplication(num1, num2);
            Console.WriteLine($"The result of {num1} * {num2} equals {result}");
            break;

        case 4:
            Division(num1, num2);
            break;

        case 5:
            break;

        default:
            Console.WriteLine("Invalid operation.");
            break;
    }

    static double Addition(double num1, double num2)
    {
        return num1 + num2;
    }

    static double Subtraction(double num1, double num2)
    {
        return num1 - num2;
    }

    static double Multiplication(double num1, double num2)
    {
        return num1 * num2;
    }

    static void Division(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        else
        {
            double result = num1 / num2;
            Console.WriteLine($"The result of {num1} / {num2} equals {result}");
        }        
    }

    Console.WriteLine("");
} while (true);

Console.WriteLine("Goodbye!");
