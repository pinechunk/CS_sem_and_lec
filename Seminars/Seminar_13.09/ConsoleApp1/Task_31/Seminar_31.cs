//Метод считывания данных пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.Write(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

//Универсальный метод генерации и заполнения массива
int[] FillArray(int num, int downBorder, int topBorder)
{
    var numCreator = new Random();
    var arr = new int[num];
    if (downBorder >= topBorder) return arr;
    for (var i = 0; i < arr.Length; i++)
    {
        arr[i] = numCreator.Next(downBorder, topBorder+1);
    }
    //Возвращаем результат
    return arr;
}

//Печатае одномерный массив
void Print1DArr(IReadOnlyList<int> arr)
{
    for (var i = 0; i < arr.Count - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Count - 1]);
}

int[] NegativePositiveSums(int[] arr)
{
    var sums = new int[2];
    foreach (var t in arr)
    {
        if (t > 0)
        {
            sums[0] += t;
        }
        else
        {
            sums[1] += t;
        }
    }
    return sums;
}

//Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
     Console.WriteLine(line);
}

int arrayLength = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите нижнюю границу заполнения массива: ");
int topBorder = ReadData("Введите верхнюю границу заполнения массива: ");

int[] inputArray = FillArray(arrayLength,downBorder,topBorder);
Print1DArr(inputArray);

int[] sumArray = NegativePositiveSums(inputArray);

PrintResult($"Сумма > 0: {sumArray[0]} Сумма < 0: {sumArray[1]}");
Print1DArr(sumArray);