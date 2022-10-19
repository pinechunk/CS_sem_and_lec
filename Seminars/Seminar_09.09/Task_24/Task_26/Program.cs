int HowManyNumbers(string line)
{
    return line.Length;
}

int ConvertData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int HowManyWithLog(int N)
{
    return (int)(Math.Log10(N) + 1);
}


string line = Console.ReadLine();
int num = ConvertData("input your kek here: ");

Console.WriteLine(HowManyNumbers(line));
Console.WriteLine(HowManyWithLog(num));