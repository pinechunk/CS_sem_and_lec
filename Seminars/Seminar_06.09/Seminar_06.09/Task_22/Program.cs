int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");

    return number;
}
string ShitsOfMultiply(int N)
{
    string outLine = String.Empty;
    for (int i = 1; i <= N; i++)
    {
        outLine += Math.Pow(i, 2) + "\t";
    }

    return outLine;
}
string begin(int N)
{
    string outLine = String.Empty;
    for (int i = 1; i <= N; i++)
    {
        outLine += i + "\t";
    }
    return outLine;
}

int number = ReadData("Input number");
string start = begin(number);
string result = ShitsOfMultiply(number);


Console.WriteLine(start);
Console.WriteLine(result);