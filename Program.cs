bool menu = true;

do {
Console.WriteLine("---Welcome to the Calculator Program---");
Console.WriteLine("Choose an operation:");

Console.WriteLine("1. Add");
Console.WriteLine("2. Subtract");
Console.WriteLine("3. Multiply");
Console.WriteLine("4. Divide");
Console.WriteLine("5. Exit");

int operation = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double result;

switch (operation) 
{
    case 1:
        result = Addition(num1, num2);
        break;
    case 2:
        result = Subtraction(num1, num2);
        break;
    case 3:
        result = Multiplication(num1, num2);
        break;
    case 4:
        result = Division(num1, num2);
        break;
    case 5:
        menu = false;
        break;
    default:
        Console.WriteLine("Invalid operation");
        break;
}


} while (menu);

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

static void PrintResult(double num1, double num2, double result)
{
    Console.WriteLine($"The result")
}


Console.WriteLine("Goodbye!");
