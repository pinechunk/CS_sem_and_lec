// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать трехмерного массива
void Print3DArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            for (int j = 0; j < matr.GetLength(2); j++)
            {
                Console.Write($"{matr[i, k, j]}, {i}-{k}-{j} ||  ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

// Заполняем массив случайными числами
void Fill3DArray(int[,,] matr, int min, int max)
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


int x = ReadData("Введите количество строк M: ");
int y = ReadData("Введите количество столбцов N: ");
int z = ReadData("Введите количество столбцов S: ");
int[,,] matrix = new int[x, y, z];


Fill3DArray(matrix, 1, 9);
Print3DArray(matrix);