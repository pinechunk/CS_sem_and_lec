string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();
int maxNumber = 0;

if (inputLineA != null && inputLineB != null && inputLineC != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);
    
    int[] arrOfNumber = new int[3] { inputNumberA, inputNumberB, inputNumberC };

    foreach (int i in arrOfNumber)
    {
        if (i > maxNumber)
            maxNumber = i;
    }
    
    Console.WriteLine(maxNumber);
}