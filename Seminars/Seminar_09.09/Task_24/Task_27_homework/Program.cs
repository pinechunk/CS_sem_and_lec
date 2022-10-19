//-------------------------------------------------------
//Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе.
//-------------------------------------------------------

int ReadData(string line)
{
    Console.Write(line);
    int N = int.Parse(Console.ReadLine() ?? "0");
    return N;
}

int CycleForAmount(int x)
{
    int amount = 0; 
    while (x > 0)
    {
        int rest = x % 10;
        amount += rest;
        x /= 10;
    }

    return amount;
}

int number = ReadData("Input the number: ");
Console.WriteLine(CycleForAmount(number));