int ReadData(string line)
{
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}

long result = 1;
long CalcFactorial(int N)
{
    if (N == 1)
    {
        return 1;
    }

    return N * CalcFactorial(N - 1);
}

int N = ReadData("Input your kek here: ");
Console.WriteLine(CalcFactorial(N));