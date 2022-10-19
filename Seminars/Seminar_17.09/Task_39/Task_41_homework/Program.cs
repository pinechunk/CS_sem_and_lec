// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*int ReadData(string line)
{
    // Выводим сообщение
    Console.Write($"{line}:");
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Заполняем массив числами, которые вводит пользователь
int [] FillArray(int n)
{
    int[] inputArray = new int [n];
    for (int i = 0; i < n; i++)
    {
        inputArray[i] = int.Parse(Console.ReadLine());
    }
    
    Console.Write($"Array: ");
    for (int i = 0; i < inputArray.Length-1; i++)
    {
        Console.Write($"{inputArray[i]}, ");
    }
    Console.Write(inputArray[^1]);
    Console.WriteLine();
    return inputArray;
}
// Считаем, сколько чисел > 0
int ColculateResult(int [] arr )
{
    int count = 0;
    foreach (var element in arr)
    {
        if (element > 0) count++;
    }

    return count;
}

int n = ReadData("Input length");

Console.WriteLine($"Count of number more then 0 is {ColculateResult(FillArray(n))}");*/

/*var key = Console.ReadKey();
//var key1 = ConsoleKey.NumPad0;
int kek = int.Parse(key.ToString());
//Console.WriteLine(key);
Console.WriteLine(kek);*/


using System.Text;
namespace Seminar_41;

class ReadFromKeyboard
{
    static void Main(string[] args)
    {
        // Инициализииуем новый экземпляр структуры 
        ConsoleKeyInfo keyInfo;
        // Создаем класс для работы со строками
        StringBuilder sb = new StringBuilder();
        {
            do
            {
                keyInfo = Console.ReadKey();
                
                switch (keyInfo.Key)
                {
                    // Устанавливаю, какие клавиши будем считывать
                    case ConsoleKey.D0:
                    case ConsoleKey.D1:
                    case ConsoleKey.D2:
                    case ConsoleKey.D3:
                    case ConsoleKey.D4:
                    case ConsoleKey.D5:
                    case ConsoleKey.D6:
                    case ConsoleKey.D7:
                    case ConsoleKey.D8:
                    case ConsoleKey.D9:
                    case ConsoleKey.OemMinus:
                    {
                        // Конкантенация введенных элементов в строку
                        sb.Append(keyInfo.KeyChar);
                        break;
                    }
                    case ConsoleKey.Enter:
                    {
                        // Вывод строки
                        Console.WriteLine();
                        //Console.WriteLine(sb.ToString());
                        bool flag = true; 
                        // Тест на позицию символа "-"
                        foreach (var element in sb.ToString())
                        {
                            if (element == '-') flag = false;
                            break;
                        }
                        // Вывод результата в соответствии с заданием
                        if (flag) Console.WriteLine($"{sb} is positive number");
                        else Console.WriteLine($"{sb} is negative number");
                        sb.Clear();
                        break;
                    }
                    default: break;
                }
            // Цикл длится, пока не будет нажат "Escape"
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}