void FirstVar()
// Вариант 1
{
    Console.WriteLine("Method 1:");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;
    
    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}
void SecondVar()
// Вариант 2
{
    Console.WriteLine("Method 2:");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    
    Console.WriteLine(number);
    
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    Console.WriteLine((firstDigit > secondDigit) ? firstDigit : secondDigit);
}
void ThirdVar()
// Вариант 3
{
    Console.WriteLine("Method 3:");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    
    Console.WriteLine(number);
    
    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0]:charArray[1]);
}
FirstVar();
SecondVar();
ThirdVar();