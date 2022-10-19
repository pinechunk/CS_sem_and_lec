//------------------------------------------
//Напишите программу, которая задаёт массив
//из 8 элементов и выводит их на экран.
//------------------------------------------

// Вариант 1
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
        arr[i] = rand.Next(0, 9);
    }
    return arr;
}    // Заполняем массив случаныйми значениями
void PrintArray(int[] inputArray)     // Распечатываем массив
{
    foreach (int element in inputArray)
    {
        Console.Write(element);
    }
}
int arrLenght = ReadData("Input length: ");
int [] myArray = GenArray(arrLenght);
PrintArray(myArray);

//Вариант 2

string [] names = {"Игорь", "Антон", "Сергей", "Стас", "Аня", "Таня", "Артем", "Даша"};
void PrintRandomNames(string[] StrArray)                       // Вывод случайного элемента массива
{                                                              // по индексу
    Random rand = new Random();
    Console.WriteLine(StrArray[rand.Next(0, StrArray.Length)]); 
}

PrintRandomNames(names);