int ReadData(string line)
{
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}

void PrintResult(string result)
{
    Console.WriteLine(result);
}

int VariantSumSimple(int numA)
{
    int sumOfNumbers = 0;
    for (int i = 0; i <= numA; i++)
    {
        sumOfNumbers += i;
    }

    return sumOfNumbers;
}

int GaussFormula(int numA)
{
    int result = (numA * (numA + 1)) / 2;
    return result;
}


/*int numberA = ReadData("Enter the number: ");
int result = VariantSumSimple(numberA);
PrintResult($"The amount from 1 to A is: {result}");*/

int numberA = ReadData("Enter the number: ");
int result = GaussFormula(numberA);
PrintResult($"The amount from 1 to A is: {result}");
