// See https://aka.ms/new-console-template for more information

using static System.Runtime.InteropServices.JavaScript.JSType;





Console.Write("Please enter the first number: ");
var a = Int32.Parse(Console.ReadLine());


Console.Write("Please enter the second number: ");
var b = Int32.Parse(Console.ReadLine());

Console.WriteLine("Result of {0} + {1} = {2}", a, b, a + b);
Console.WriteLine("Result of {0} - {1} = {2}", a, b, a - b);
Console.WriteLine("Result of {0} * {1} = {2}", a, b, a * b);
Console.WriteLine("Result of {0} / {1} = {2}", a, b, a / b);
Console.WriteLine("Result of {0} % {1} = {2}", a, b, a % b);





// Prompt user to enter the first number
Console.Write("Please enter the first number: ");
if (int.TryParse(Console.ReadLine(), out int a))
{
    // Prompt user to enter the second number
    Console.Write("Please enter the second number: ");
    if (int.TryParse(Console.ReadLine(), out int b))
    {
        Console.WriteLine("Result of {0} + {1} = {2}", a, b, a + b);
        Console.WriteLine("Result of {0} - {1} = {2}", a, b, a - b);
        Console.WriteLine("Result of {0} * {1} = {2}", a, b, a * b);
        Console.WriteLine("Result of {0} / {1} = {2}", a, b, a / b);
        Console.WriteLine("Result of {0} % {1} = {2}", a, b, a % b);
    }
    else
    {
        Console.WriteLine("Error! Invalid input for the second number.");
        return;
    }
}
else
{
    Console.WriteLine("Error! Invalid input for the first number.");
    return;
}




// Prompt user to enter the first number
Console.Write("Please enter the first number: ");
if (int.TryParse(Console.ReadLine(), out int a))
{
    // Prompt user to enter the second number
    Console.Write("Please enter the second number: ");
    if (int.TryParse(Console.ReadLine(), out int b))
    {
        // Prompt user to enter the operator
        Console.Write("Please enter an operator (&, |, ^): ");
        char op = Console.ReadKey().KeyChar; // Считываем один символ
        Console.WriteLine(); // Переход на новую строку

        // Проверка введенного оператора
        if (op == '&' || op == '|' || op == '^')
        {
            // Выполнение операции в зависимости от введенного оператора
            int result = 0;
            switch (op)
            {
                case '&':
                    result = a & b;
                    break;
                case '|':
                    result = a | b;
                    break;
                case '^':
                    result = a ^ b;
                    break;
            }

            Console.WriteLine("Result of {0} {1} {2} = {3}", a, op, b, result);
            Console.WriteLine("Decimal: {0}", result);
            Console.WriteLine("Binary: {0}", Convert.ToString(result, 2));
            Console.WriteLine("Hexadecimal: {0}", result.ToString("X"));
        }
        else
        {
            Console.WriteLine("Error! Invalid operator.");
            return; // Завершаем выполнение программы
        }
    }
    else
    {
        Console.WriteLine("Error! Invalid input for the second number.");
        return; // Завершаем выполнение программы
    }
}
else
{
    Console.WriteLine("Error! Invalid input for the first number.");
    return; // Завершаем выполнение программы
}