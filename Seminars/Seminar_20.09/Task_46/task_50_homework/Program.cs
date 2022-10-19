// Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.

int ReadData(string line)
{
    // Выводим сообщение
    Console.Write($"{line}: ");
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}
// Рекурсивный метод для числа Фибоначчи
double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
// Заполняю матрицу вещественными числами
void FillMatrix(double[,] matr)
{
    int count = 1;
    Random rand = new Random();
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows, columns] = Fibonacci(count);
            count++;
        }  
    }
}
// Распечатываю матрицу с условием
void PrintMatrix(double[,] matr, int x, int y)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            if (matr[rows, columns] == matr[x, y])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0,6:F2} ", matr[rows, columns]);
                Console.ResetColor();
                continue;
            } 
            Console.Write("{0,6:F2} ", matr[rows, columns]);
        }
        Console.WriteLine();

    }
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int x = ReadData("Введите индекс по вертикали ");
int y = ReadData("Введите индекс по горизонтали ");

double [,] matrix = new double [row, column];
FillMatrix(matrix);
PrintMatrix(matrix, x, y);
