// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать двумерного массива
void Print3DArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            for (int j = 0; j < matr.GetLength(2); j++)
            {
                Console.Write($"{matr[i, k, j]} ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

// Заполняем массив случайными числами
void Fill3DArray(int[,,] matr, int min, int max, int z)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            for (int j = 0; j < matr.GetLength(2); j++)
            {
                matr[i, k, j] = new Random().Next(min, max + 1);
            }
        }
    }
}


int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int s = ReadData("Введите количество столбцов S: ");
int[,,] matrix = new int[m, n, s];


Fill3DArray(matrix, 1, 9, s);
Print3DArray(matrix);
