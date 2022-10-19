int ReadData(string line)
{
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}
int[] GenArray(int arrLength)
{
    int[] arr = new int[arrLength];
    Random rand = new Random();
    for (int i = 0; i < arrLength; i++)
    {
        arr[i] = rand.Next(0, 2);
    }
    return arr;
}
void PrintArray(int[] inputArray)
{
    foreach (int element in inputArray)
    {
        Console.Write(element);
    }
}
int arrLenght = ReadData("Input length: ");
int [] myArray = GenArray(arrLenght);
PrintArray(myArray);
