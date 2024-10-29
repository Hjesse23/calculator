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
            result = Division(num1, num2);
            Console.WriteLine($"The result of {num1} / {num2} equals {result}");
            break;
        case 5:
            break;
    }

    static double Addition(double a, double b)
    {
        return a + b;
    }

    static double Subtraction(double a, double b)
    {
        return a - b;
    }

    static double Multiplication(double a, double b)
    {
        return a * b;
    }

    static double Division(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Number can't be divided by zero");
        }
        else
        {
            return a / b;
        }
    }

    Console.WriteLine("");

} while (true);

Console.WriteLine("Goodbye!");
