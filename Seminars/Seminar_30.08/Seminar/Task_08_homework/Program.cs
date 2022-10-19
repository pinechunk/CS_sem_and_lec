string inputLineN = Console.ReadLine();
if (inputLineN != null)
{
    int inputNumberN = int.Parse(inputLineN);
    int startNumber = 2;
    
    while (startNumber < inputNumberN)
    {
        if (startNumber % 2 == 0)
            Console.Write(startNumber + ", ");
        startNumber += 2;
    }
    Console.WriteLine(inputNumberN);
}