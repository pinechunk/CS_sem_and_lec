string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    bool result = (inputNumber % 2 == 0);
    
    Console.WriteLine(result);
}