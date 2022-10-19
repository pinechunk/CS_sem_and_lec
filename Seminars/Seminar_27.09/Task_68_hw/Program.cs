int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int AkkermanFunc(int n, int m)
{
    if (n == 0) return m + 1;
    if ((n != 0) && (m == 0)) return AkkermanFunc(n - 1, 1);
    return AkkermanFunc(n - 1, AkkermanFunc(n, m - 1));
}
 
int numberFirst = ReadData("Input number: ");
int numberSecond = ReadData("Input number: ");

Console.WriteLine(AkkermanFunc(numberFirst, numberSecond));
