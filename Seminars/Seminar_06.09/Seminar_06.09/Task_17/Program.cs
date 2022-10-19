int ReadData(string line)
{
    //Вводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");

    return number;
}

int QuarterTest(int x, int y)
{
    if (x>0 && y>0)
        return 1;
    if (x>0 && y<0)
        return 2;
    if (x<0 && y<0)
        return 3;
    if (x<0 && y>0)
        return 4;

    return 0;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x = ReadData("Input x");
int y = ReadData("input y");

int result = QuarterTest(x, y);

PrintResult($"Point is in quarter №{result}");