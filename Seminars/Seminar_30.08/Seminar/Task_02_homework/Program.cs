string? numberA = Console.ReadLine();
string? numberB = Console.ReadLine();
if (numberA != null && numberB != null)
{
    int inputNumberA = int.Parse(numberA);
    int inputNumberB = int.Parse(numberB);

    if (inputNumberA > inputNumberB)
    {
        Console.WriteLine(inputNumberA);
    }
    else
    {
        Console.WriteLine(inputNumberB);
    }
}