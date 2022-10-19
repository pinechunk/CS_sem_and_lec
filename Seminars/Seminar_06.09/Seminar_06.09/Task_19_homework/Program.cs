//------------------------------------------------------------
//Напишите программу, которая принимает на вход
//пятизначное число и проверяет, является ли оно палиндромом.
//-------------------------------------------------------------

// Вариант 1
bool Reverse(string line)
{
    if (line == new string(line.Reverse().ToArray()))
    {
        return true;
    }
    else
    {
        return false;
    }
}                      // Разворачиваем строку и
                                                    // сравниваем с оригинальной
string PrintResult(bool result, string line)
{
    if (result)
    {
        Console.WriteLine($"Число {line} является полиндромом");
    }
    else
    {
        Console.WriteLine($"Число {line} не является полиндромом");
    }

    return "";
}   // Возвращаем решение

string line = Console.ReadLine();
PrintResult(Reverse(line), line);

//==========================================================
//==========================================================

// Вариант 2
int ReadData(string line)
{
    int number = int.Parse(line);
    return number;
}

bool TestPolindrom(int number)
{
    if (number / 10000 == number % 10)
    {
        if ((number / 1000) % 10 == (number % 100) / 10)
        {
            return true;
        }
    }

    return false;
}                   // Метод отличается от предыдущего тем,
                                                      // что сравнивает числа по остатку от деления

int PrintData(bool res, int number)
{
    if (res)
    {
        Console.WriteLine($"Число {line} является полиндромом");
    }
    else
    {
        Console.WriteLine($"Число {line} не является полиндромом");
    }

    return 0;
}

string inputLine = Console.ReadLine();
PrintData(TestPolindrom(ReadData(inputLine)), ReadData(inputLine));

//==========================================================
//==========================================================