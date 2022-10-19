//--------------------------------------------------
//Напишите программу, которая принимает на вход число
//(N) и выдаёт таблицу кубов чисел от 1 до N.
//---------------------------------------------------

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");

    return number;
}
//Печать таблицы кубов
string ShitsOfMultiply(int N)
{
    string x = String.Empty;
    string y = String.Empty;

    for (int i = 1; i <= N; i++)                                //Завожу цикл для вычисления каждого элемента таблицы
    {
        Console.WriteLine("{0,10}   |{1,10}", i,Math.Pow(i, 3)); //Распечатка таблицы 
    }
    return "";
}

int number = ReadData("Input number");
string result = ShitsOfMultiply(number);

Console.WriteLine(result);