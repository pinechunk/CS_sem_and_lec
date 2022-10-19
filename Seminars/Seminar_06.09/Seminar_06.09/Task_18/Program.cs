int ReadData(string line)
{
    //Вводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");

    return number;
}

string QuarterBorderAsk(int numQuarter)
{
    if (numQuarter == 1)
        return "x>0 y>0";
    if (numQuarter == 2)
        return "x>0 y<0";
    if (numQuarter == 3)
        return "x<0 y<0";
    if (numQuarter == 4)
        return "x<0 y>0";
    return "nothing";
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Input number of quarter");

string result = QuarterBorderAsk(num);

PrintResult($"{result}");