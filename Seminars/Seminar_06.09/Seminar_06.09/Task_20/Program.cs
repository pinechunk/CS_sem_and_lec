int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");

    return number;
}

double RangeBetWeenPoints(int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return result;
}

void PrintResult(double line)
{
    Console.WriteLine(line);
}

int x1 = ReadData("Input x1");
int y1 = ReadData("Input y1");
int x2 = ReadData("Input x2");
int y2 = ReadData("Input y2");

double result = RangeBetWeenPoints(x1, x2, y1, y2);

PrintResult(Math.Round(result, 2));  // Сколько цифр будет после запятой