string? inputLine = Console.ReadLine();
int A = int.Parse(inputLine);

void Colculate()
{
    if (A % 7 == 0 && A % 23 == 0)
    {
        Console.WriteLine("Число кратно и 7, и 23");
    }
    else
    {
        Console.WriteLine("Число не кратно и 7, и 23");
    }
}
