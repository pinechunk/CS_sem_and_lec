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
//  Нахожу произведение матриц
int[,] MultiplyMatrix(int[,] ar1, int[,] ar2)
{
    int[,] m = new int[ar1.GetLength(0), ar2.GetLength(1)];
 
    for (int i = 0; i < ar1.GetLength(0); ++i)
    for (int j = 0; j < ar2.GetLength(0); ++j)
    for (int k = 0; k < ar2.GetLength(1); ++k)
        m[i, k] += ar1[i, j] * ar2[j, k];
    return m;
}

int m = ReadData("Введите количество строк первой M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[m, n];

Fill2DArray(matrix1, 1, 9);
Print2DArray(matrix1);
Fill2DArray(matrix2, 1, 9);
Print2DArray(matrix2);
Print2DArray(MultiplyMatrix(matrix1, matrix2));
