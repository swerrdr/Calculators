using CalculatorBasic.Interface;
using CalculatorBasic.Classes;
while (true)
{
    ICalculatorBasic _calc = new calculator();
    Console.WriteLine("did you want you use app?");
    var answer = Console.ReadLine().Trim().ToLower();
    if (answer == "yes")
    {
        float first_number, second_number, result;
        char sign;

        Console.Write("Write your first number: ");
        first_number = Convert.ToSingle(Console.ReadLine());

        Console.Write("Write your second number: ");
        second_number = Convert.ToSingle(Console.ReadLine());

        Console.Write("What do you want to do? (write: *, +, -, / : ");
        sign = Convert.ToChar(Console.ReadLine());

        if (sign == '*')
        {
            Console.WriteLine(_calc.multiplication(first_number, second_number));
        }
        else if (sign == '+')
        {
            Console.WriteLine(_calc.Addition(first_number, second_number));
        }
        else if (sign == '-')
        {
            Console.WriteLine(_calc.substaction(first_number, second_number));
        }
        else if (sign == '/')
        {
            Console.WriteLine(_calc.Divetion(first_number, second_number));
        }
        else
        {
            Console.WriteLine("input error");
        }
    }

    else
    {
        Console.WriteLine("Goodbye!");
        break;
    }
}