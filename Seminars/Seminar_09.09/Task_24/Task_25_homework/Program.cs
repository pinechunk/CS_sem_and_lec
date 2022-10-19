//-------------------------------------------------------
//Напишите цикл, который принимает на вход два числа
//(A и B) и возводит число A в натуральную степень B.
//-------------------------------------------------------
// Вариант 1
int ConvertData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int CycleForDegree(int x, int y, int result = 1)
{
    for (int i = 0; i < y; i++)
    {
        result *= x;
    }

    return result;
}

int inputX = ConvertData("Input your number:");
int inputY = ConvertData("Input your degree:");

Console.WriteLine($"{inputX} in degree {inputY} is {CycleForDegree(inputX, inputY)}");

// Вариант 2


int Calculator(int x, int y, string sign)  // В зависимости от введенного знака
{                                          // будет выполнятся определенное действие
    if (sign == "+")
    {
        return x + y;
    }

    if (sign == "-")
    {
        return x - y;
    }
    if (sign == "/")
    {
        return x / y;
    }
    if (sign == "*")
    {
        return x * y;
    }
    if (sign == "^")
    {
        double c = Math.Pow(x, y);
        int result = Convert.ToInt32(c);
        return result;
    }

    return 0;
}     

int firstNum = ConvertData("Input first num: ");
Console.WriteLine("Input sign (for degree you can use '^'): ");   // Для возведения в степень я зарезервировал
string sign = Console.ReadLine();                                 // знак '^'
int secondNum = ConvertData("Input second num: ");

Console.WriteLine($"The result is: {Calculator(firstNum, secondNum, sign)}");
