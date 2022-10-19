void FirstVar()
{
    Console.WriteLine("Method 1:");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 1000);

    Console.WriteLine(number);

    int firstNumber = number / 100;
    int lastNumber = number % 10;
    Console.WriteLine(firstNumber * 10 + lastNumber);
}

void SecondVar()
{
    Console.WriteLine("Method 2:");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 1000);
    
    Console.WriteLine(number);

    char[] arr = number.ToString().ToCharArray();
    Console.Write(arr[0]);
    Console.WriteLine(arr[2]);
}
FirstVar();
SecondVar();