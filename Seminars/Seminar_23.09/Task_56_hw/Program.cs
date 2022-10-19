// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}
// Заполняем массив случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}
//  Нахожу строку с минимальной суммой
void Calc2DArray(int[,] matr)
{
    int minSumm = 99999;
    int temp = 0;
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            temp += matr[i, j];
        }

        if (temp <= minSumm)
        {
            minSumm = temp;
            count = i + 1;
        }
    }

    Console.WriteLine($"Строка с наименьшей суммой элементов — {count}, наименьшая сумма — {minSumm}");
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = new int[m, n];


Fill2DArray(matrix, 1, 9);
Print2DArray(matrix);
Calc2DArray(matrix);
